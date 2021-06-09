var modal =
{
    get: function (modalId, divId, actionUrl, parameters, onSuccess, onError) {

        loader.load(true);

        var successMethod = function (data) {
            $("#" + divId).html(data);

            $('#' + modalId).modal({ backdrop: 'static' })

            modal.show(modalId);

            loader.load(false);
        };

        var errorMethod = function (error) {
            // showErrorMessage
            notification.notifyErrorMessage(error.statusText);
            loader.load(false);
        };

        if (onSuccess != null)
            successMethod = onSuccess;

        if (onError != null)
            errorMethod = onError;

        $.get(actionUrl, parameters, successMethod).fail(errorMethod);
    }
    ,
    hide: function (modalId) {
        $("#" + modalId).modal('hide');
    }
    ,
    show: function (modalId) {
        $("#" + modalId).modal('show');
    }
}