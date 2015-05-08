function traverseDom(selector) {
    var element = document.querySelector(selector);
    var result = '';

    function traverseNode(node, spacing) {
        spacing = spacing || '';
        result += spacing + node.nodeName.toLocaleLowerCase() + ": ";

        for (var i = 0; i < node.attributes.length; i += 1) {
            result += node.attributes[i].name + '=\"' + node.attributes[i].value + '\" ';
        }

        result += '\n';

        for (i = 0; i < node.childNodes.length; i += 1) {
            var childNode = node.childNodes[i];
            if (childNode.nodeType === document.ELEMENT_NODE) {
                traverseNode(childNode, spacing + '\t');
            }
        }
    }

    traverseNode(element);

    return result;

}

var selector = ".birds";
console.log(traverseDom(selector));

