var domModule = (function () {
    function appendChild(element, child) {
        var parentNode = getNodeFromDomElementOrSelector(element, 'Parent node');
        var childNode = getNodeFromDomElementOrSelector(child, 'Child node');

        parentNode.appendChild(childNode);

    }

    function removeChild(element, child) {
        var parentNode = getNodeFromDomElementOrSelector(element, 'Parent node');
        var childNode = getNodeFromDomElementOrSelector(child, 'Child node');

        parentNode.removeChild(childNode);
    }

    function addHandler(element, eventType, eventHandler) {
        var nodes = retrieveElements(element);
        for (var i = 0; i < nodes.length; i++) {
            nodes[i].addEventListener(eventType, eventHandler);
        }
    }

    function retrieveElements(selector){
        return document.querySelectorAll(selector);
    }

    function getNodeFromDomElementOrSelector(element, elementName) {
        if (element.nodeType !== document.ELEMENT_NODE) {
            var elementFromSelector = document.querySelector(element);
            if (elementFromSelector === null) {
                throw new ReferenceError(elementName + ' cannot be found.');
            }

            return elementFromSelector;
        }

        return element;
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };
}());

var liElement = document.createElement("li");
// Appends a list item to ul.birds-list
domModule.appendChild(".birds-list", liElement);
// Removes the first li child from the bird list
domModule.removeChild("ul.birds-list","li:first-child");
// Adds a click event to all bird list items
domModule.addHandler("li.bird", 'click', function(){ alert("I'm a bird!") });
// Retrives all elements of class "bird"
var elements = domModule.retrieveElements(".bird");
console.log(elements);



