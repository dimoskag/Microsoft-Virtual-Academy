$(function () {
    //By id
    $('#first').addClass('highlight');

    //By element
    $('p').addClass('highlight');

    //By class
    $('.chosen').addClass('highlight');

    //Combinations
    $('#first, .chosen').addClass('highlight');

    //Contains
    $('li:contains("three")').addClass('highlight');
    $('li:even').addClass('highlight');

    //next, previous
    $('li:contains("three")').prev().addClass('highlight');

    //siblings, parent
    $('li:contains("three")').siblings().addClass('highlight');
    $('li:contains("three")').parent().addClass('highlight');

    $('li:nth-child(1)').addClass('highlight');

    //attributes
    $('p[name="mySecondPara"]').addClass('highlight');
    $('p[name!="mySecondPara"]').addClass('highlight');
    $('p').not('[name]').addClass('highlight');
    $(':header').addClass('highlight');
    $('p:empty').text('You seemed...');

});