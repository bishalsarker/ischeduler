	
	$(window).resize(function(){
		navBar();
	});

	$(window).load(function(){
		navBar();
	});

	function navBar(){
		var width = $(window).width();
		if((width < 721)){
			$("#navcon").attr("class", "nav-container");
			$("#menu-icon").attr("class", "menu-icon-mobile nav-icon");
			$("#add-icon").attr("class", "add-icon-mobile nav-icon");
			$("#logo").attr("class", "logo");
		}
		else{
			$("#navcon").attr("class", "row nav-container");
			$("#menu-icon").attr("class", "col-1 nav-icon");
			$("#add-icon").attr("class", "col-1 nav-icon");
			$("#logo").attr("class", "col-10 logo center");
		}
	}

	function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
	}

	function closeNav() {
	    document.getElementById("mySidenav").style.width = "0";
	}