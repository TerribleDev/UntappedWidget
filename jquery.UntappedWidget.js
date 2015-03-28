(function ($) {
    //I would love to use handlebars, but I am trying to limit the required packages
    var buildProfileTemplate = function (data, badges) {
        return "<div class=\"profile\" style=\"background-image: Url(" + data.headerBackgroundUrl + ")\"><div class=\"user-info\">\
        <div class=\"user-avatar\">\
            <div class=\"avatar-holder\">\
                <img src=\""+ data.avatarUrl + "\" alt=\"User Avatar\" />\
            </div>\
        </div>\
        <div class=\"info\">\
            <h1>"+ data.info + "</h1>\
            <span class=\"username\">"+ data.username + "</span>\
        </div>\
    </div>\
    <div class=\"stats-bar\">\
        <span class=\"badges\">"+ badges + "\
        </span>\
    </div>\
</div>";


    }
    var buildBadges = function(data) {
        var badges = "";
        $.each(data.badges, function(index, value) {
            badges = badges + "<a href=\"" + value.linkUrl + "\" ><span><img src=\"" + value.imageUrl + "\" /></span></a>";
        });

        return badges;
    };

    $.fn.untappd = function (username) {
        this.each(function () {
            var that = this;
            $.get("http://untappdwidget.azurewebsites.net/" + username, function(data) { $(that).html(buildProfileTemplate(data, buildBadges(data))); }, "jsonp");
        });
    };


})(jQuery);


