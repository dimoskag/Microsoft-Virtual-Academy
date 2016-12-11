function runTheExample() {
    alert("running the example");
}

window.onload = function () {
    //var clickMeButton = document.getElementById("clickMe");
    //clickMeButton.onclick = runTheExample();
    document.getElementById("clickMe").onclick = runTheExample;
}

function runtTheExample() {
    var myElement = document.getElementById("second");
    var myNodeName = myElement.nodeName;
    if (myElement != null) {
        alert(myElement.innerHTML);
    }
    document.getElementById("second").innerHTML = "See how I set the text here?";

    var listOfParagraphs = document.getElementsByTagName("p");
    alert(listOfParagraphs.length);

    var secondParagraph = listOfParagraphs[1];
    alert(secondParagraph.innerHTML);

    myElement = document.getElementById("second");
    alert(myElement.parentNode.nodeName);

    myElement.childNodes[0];
    myElement.firstChild;
    myElement.lastChild;
    myElement.nextSibling;
    myElement.previousSibling;

    var anchor = document.getElementById("myAnchor");
    var anchorDestination = anchor.href;
    alert(anchorDestination);

    anchor.href = "http://www.learningtest.net";
    anchor.setAttribute("href", "http://test");


}