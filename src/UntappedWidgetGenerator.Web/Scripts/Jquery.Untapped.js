(function ($) {
    $.fn.untappd = function (username) {
        this.each(function () {
            var that = this;
            $.post("http://localhost:12116/" + username)
                .success(function (data) {
                    $(that).html(data);
            });
        });
    };
})(jQuery);