var loader = {
    load: function (isVisible, target) {

        if (!target)
            target = ".loader-div";

        if (visible) {
            $(target).html(defaultContent.loading);
        } else {
            $(target).empty();
        }
    }
}