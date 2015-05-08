var Noty = (function () {
    function display(type, text, time, layout, closeOption) {
        var n = noty({
            type: type,
            text: text,
            timeout: time,
            layout: layout,
            closeWith: [closeOption],
            dismissQueue: true
        });
    }

    function success(text, layout) {
        display('success', text, 2000, layout, 'click');
    }

    function error(text, layout) {
        display('error', text, 4000, layout, 'button');
    }

    return {
        success: success,
        error: error
    }
})();

//function showInfoMessage(msg) {
//    noty({
//            text: msg,
//            type: 'info',
//            layout: 'topCenter',
//            timeout: 5000}
//    );
//}
//
//function showErrorMessage(msg) {
//    noty({
//            text: msg,
//            type: 'error',
//            layout: 'topCenter',
//            timeout: 5000}
//    );
//}
