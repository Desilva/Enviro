using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace env.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string alpha_name { get; set; }
        public string signature { get; set; }
        public string position { get; set; }
        public string email { get; set; }
        public int? delagate { get; set; }
        public int? employee_boss { get; set; }
        public int? approval_level { get; set; }
        public string department { get; set; }

        /*
         * Constructor
         * empty constructor
         */
        public UserModel() { }

        /* 
         * Constructor
         * get user model object if id defined
         */
        public UserModel(int id /* user id */, string token, int curLoginId)
        {
            WWUserService.UserServiceClient client = new WWUserService.UserServiceClient();

            WWUserService.ResponseModel response = client.getUser(token, curLoginId, id);

            if (response.status)
            {
                this.clone(response.result);
            }

            client.Close();
        }

        /*
         * isSupervisor
         * if user is Supervisor
         * return: bool (true, if user is supervisor)
         */
        public bool isSupervisor()
        {
            // code here
            return approval_level == 1;
        }

        /*
         * isSuperintendent
         * if user is Superintendent
         * return: bool (true, if user is superintendent)
         */
        public bool isSuperintendent()
        {
            // code here
            return approval_level == 2;
        }

        /*
         * findSuperintendent
         * find superintendent of supervisor, 
         * if superintendent then return him/herself
         * return: UserModel (user of superintendent)
         */
        public UserModel findSuperintendent(string token, int curLoginId)
        {
            // code here
            WWUserService.UserServiceClient client = new WWUserService.UserServiceClient();

            WWUserService.ResponseModel response = client.getSuperintendent(token, curLoginId, this.id);
            UserModel user = new UserModel();
            if (response.status)
            {
                user.clone(response.result);
            }

            client.Close();
            return user;
        }


        /*
         * isPlanning
         * if user is in planning section
         * return: bool (true, if user is in planning section)
         */
        public bool isPlanning()
        {
            // code here
            return true;
        }

        public UserModel clone(WWUserService.UserModel cloningUser)
        {
            this.id = cloningUser.id;
            this.alpha_name = cloningUser.alpha_name;
            this.signature = cloningUser.signature;
            this.position = cloningUser.position;
            this.email = cloningUser.email;
            this.delagate = cloningUser.delagate;
            this.employee_boss = cloningUser.employee_boss;
            this.approval_level = cloningUser.approval_level;
            this.department = cloningUser.department;

            return this;
        }

        public List<UserModel> getAllEmployee(string token, int curLoginId)
        {
            WWUserService.UserServiceClient client = new WWUserService.UserServiceClient();
            int count = 0;
            List<UserModel> listUser = new List<UserModel>();
            WWUserService.ResponseModel response = client.listUser(token, curLoginId, 50, 250);

            while (response.status && count < response.results.count)
            {
                foreach (WWUserService.UserModel us in response.results.listUserModel)
                {
                    listUser.Add(new UserModel().clone(us));
                }

                response = client.listUser(token, curLoginId, 50, count);
                count += 50;
            }

            client.Close();

            return listUser.OrderBy(p => p.alpha_name).ToList();
        }
    }

    public class LoginModel
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        public string errorMessage { get; set; }
    }
}