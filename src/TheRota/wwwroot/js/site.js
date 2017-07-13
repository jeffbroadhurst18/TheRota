// Write your Javascript code.
(function () {

    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $sidebar = $("#sidebar");

    // toggleclass adds or removes a class
    $("#sidebarToggle").on("click", function () {
        var $icon = $("#sidebarToggle i.fa");
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
        else {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
    })

    $("#colourToggle").on("click", function () {
        $sidebar.toggleClass("alternate-colour");
    }
        
        )

})();