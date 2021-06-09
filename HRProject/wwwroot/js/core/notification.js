var notification =
{
    successMessage: "",

    setInitialMessage: function (successMessage) {
        notification.successMessage = successMessage;
    }
    ,
    notifyErrorMessage: function (message) {
        toastr.error(message);
    }
    ,
    notifyWarningMessage: function (message) {
        toastr.warning(message);
    }
    ,
    notifySuccessMessage: function (message) {
        toastr.success(message);
    }
    ,
    notifySuccessMessage: function () {
        notification.notifyMessage(notification.successTitle, notification.successMessage, 'success', 2500, true);
    }
}