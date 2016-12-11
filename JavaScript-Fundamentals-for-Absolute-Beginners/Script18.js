$(function () {
    var version = "1.2";
    alert(window.version);

    //document.write("");
    $('#clickMe').toggle(function () {
        ('#message').show('fast');
        $('#clickMe').attr('src', 'minus-8.png');
    }, function () {
        $('#message').hide('slow');
        $('#clickMe').attr('src', 'plus-8.png');
    });
    $('#message').hide();
});

var AETRIS = {};

AETRIS.version = "1.2";

AETRIS.planet = {
    id: 34,
    name: "Intempstesta Nox"
};