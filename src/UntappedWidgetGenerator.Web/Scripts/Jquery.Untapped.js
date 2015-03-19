(function ($) {
    $.fn.untappd = function (username) {
        this.each(function () {
            var that = this;
            $.get("http://untappdwidget.azurewebsites.net/" + username)
                .success(function (data) {
                    $(that).html(data);
            });
        });
    };
})(jQuery);