(function ($) {
    $.fn.untappd = function (username) {
        this.each(function () {
            var that = this;
            $.post("http://untappedwidget.azurewebsites.net/" + username)
                .success(function (data) {
                    $(that).html(data);
            });
        });
    };
})(jQuery);