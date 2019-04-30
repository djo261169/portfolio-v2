$(document).ready(function () {
    var $Menu = $('.Menu');
    $('.Menu-Button').on('click', function () {

        var $menu = $('.Menu');
        var $BTN = $('.Menu-Button');
        var $body = $('#Container');
        if ($menu.hasClass('clicked')) {
            $menu.removeClass('clicked');
            $body.removeClass('clicked2');
            $BTN.removeClass('clicked3');
        } else {
            $menu.addClass('clicked');
            $body.addClass('clicked2');
            $BTN.addClass('clicked3');
        }
    });
});