$(function () {
    function buildACat() {
        var catName = "Mr. Tibbles";
        function catFactory() {
            alert(catName);
        }
        catFactory();
    }
    $('#buildcat').click(function () {
        buildACat();
    });
});

$(function () {
    function buildACat() {
        var catName = "tuffy";
        function catFactory() {
            alert(catName);
        }
        return catFactory;
    }
    $('#buildcat').click(function () {
        var myNewCat = buildACat();
        myNewCat();
    });
});

//modular pattern
a = (function () {
    var privateFunction = function () {
        alert('hello');
    }
    return {
        publicFunction: function () {
            privateFunction();
        }
    }
})();
a.publicFunction();