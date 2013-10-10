/**
 * Unicorn Admin Template
 * Diablo9983 -> diablo9983@gmail.com
**/
$(document).ready(function(){

    addHandlerMenu();
	
	// === Sidebar navigation === //
	
	$('.submenu > a').click(function(e)
	{
		e.preventDefault();
		var submenu = $(this).siblings('ul');
		var li = $(this).parents('li');
		var submenus = $('#sidebar li.submenu ul');
		var submenus_parents = $('#sidebar li.submenu');
		if(li.hasClass('open'))
		{
			if(($(window).width() > 768) || ($(window).width() < 479)) {
				submenu.slideUp();
			} else {
				submenu.fadeOut(250);
			}
			li.removeClass('open');
		} else 
		{
			if(($(window).width() > 768) || ($(window).width() < 479)) {
				submenus.slideUp();			
				submenu.slideDown();
			} else {
				submenus.fadeOut(250);			
				submenu.fadeIn(250);
			}
			submenus_parents.removeClass('open');		
			li.addClass('open');	
		}
	});
	
	var ul = $('#sidebar > ul');
	
	$('#sidebar > a').click(function(e)
	{
		e.preventDefault();
		var sidebar = $('#sidebar');
		if(sidebar.hasClass('open'))
		{
			sidebar.removeClass('open');
			ul.slideUp(250);
		} else 
		{
			sidebar.addClass('open');
			ul.slideDown(250);
		}
	});
	
	// === Resize window related === //
	$(window).resize(function()
	{
		if($(window).width() > 479)
		{
			ul.css({'display':'block'});	
			$('#content-header .btn-group').css({width:'auto'});		
		}
		if($(window).width() < 479)
		{
			ul.css({'display':'none'});
			fix_position();
		}
		if($(window).width() > 768)
		{
			$('#user-nav > ul').css({width:'auto',margin:'0'});
            $('#content-header .btn-group').css({width:'auto'});
		}
	});
	
	if($(window).width() < 468)
	{
		ul.css({'display':'none'});
		fix_position();
	}
	if($(window).width() > 479)
	{
	   $('#content-header .btn-group').css({width:'auto'});
		ul.css({'display':'block'});
	}
	
	// === Tooltips === //
	$('.tip').tooltip();	
	$('.tip-left').tooltip({ placement: 'left' });	
	$('.tip-right').tooltip({ placement: 'right' });	
	$('.tip-top').tooltip({ placement: 'top' });	
	$('.tip-bottom').tooltip({ placement: 'bottom' });	
	
	// === Search input typeahead === //
	$('#search input[type=text]').typeahead({
		source: ['Dashboard','Form elements','Common Elements','Validation','Wizard','Buttons','Icons','Interface elements','Support','Calendar','Gallery','Reports','Charts','Graphs','Widgets'],
		items: 4
	});
	
	// === Fixes the position of buttons group in content header and top user navigation === //
	function fix_position()
	{
		var uwidth = $('#user-nav > ul').width();
		$('#user-nav > ul').css({width:uwidth,'margin-left':'-' + uwidth / 2 + 'px'});
        
        var cwidth = $('#content-header .btn-group').width();
        $('#content-header .btn-group').css({width:cwidth,'margin-left':'-' + uwidth / 2 + 'px'});
	}
	
	// === Style switcher === //
	$('#style-switcher i').click(function()
	{
		if($(this).hasClass('open'))
		{
			$(this).parent().animate({marginRight:'-=220'});
			$(this).removeClass('open');
		} else 
		{
			$(this).parent().animate({marginRight:'+=220'});
			$(this).addClass('open');
		}
		$(this).toggleClass('icon-arrow-left');
		$(this).toggleClass('icon-arrow-right');
	});
	
	$('#style-switcher a').click(function()
	{
		var style = $(this).attr('href').replace('#','');
		$('.skin-color').attr('href','Content/unicorn.'+style+'.css');
		$(this).siblings('a').css({'border-color':'transparent'});
		$(this).css({'border-color':'#aaaaaa'});
	});
});

function addHandlerMenu() {
    $('.content-setting').click(function () {
        $('#content').load('admin/PartialIndex');
        setActiveMenu('home');
    });

    $('#sources-waste').click(function () {
        $('#content').load('SourceWaste/Index');
        document.title = "Enviro - Sources of Waste";
        setActiveHomeMenu('sources-waste');
    });

    $('#waste').click(function () {
        $('#content').load('Waste/Index');
        document.title = "Enviro - Waste";
        setActiveHomeMenu('waste');
    });

    $('#unit').click(function () {
        $('#content').load('WasteUnit/Index');
        document.title = "Enviro - Waste Unit";
        setActiveHomeMenu('unit');
    });

    $('#type-waste').click(function () {
        $('#content').load('TypeWaste/Index');
        document.title = "Enviro - Type of Waste";
        setActiveHomeMenu('type-waste');
    });

    $('#hazardous-waste').click(function () {
        $('#content').load('HazardousRecord/Index');
        document.title = "Enviro - Hazardous Waste Record";
        setActiveWasteMenu('hazardous-waste');
    });

    $('#non-hazardous-waste').click(function () {
        $('#content').load('NonHazardousRecord/Index');
        document.title = "Enviro - Non Hazardous Waste Record";
        setActiveWasteMenu('non-hazardous-waste');
    });

    $('#hazard-month-report').click(function () {
        $('#content').load('HazardousMonthReport/Index');
        document.title = "Enviro - Hazardous Waste Monthly Report";
        setActiveReportMenu('hazard-month-report');
    });

    $('#hazard-year-report').click(function () {
        $('#content').load('HazardousAnnualReport/Index');
        document.title = "Enviro - Hazardous Waste Annual Report";
        setActiveReportMenu('hazard-year-report');
    });
}

function setActiveHomeMenu(id) {
    $('.active').removeClass('active');
    $('#home').addClass('active');
    $('#' + id).addClass('active');
}

function setActiveWasteMenu(id) {
    $('.active').removeClass('active');
    $('#waste-data').addClass('active');
    $('#' + id).addClass('active');
}

function setActiveReportMenu(id) {
    $('.active').removeClass('active');
    $('#waste-report').addClass('active');
    $('#' + id).addClass('active');
}

function changeContent(url) {
    $('#content').load(url);
}
