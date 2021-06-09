var selectedId, selectedStructureId, selectedAbsolutelyId, selectedAbsolutelyGridId, workId, flowId, canEdit, canDelete, canPrint, productType, operation, productId, docType;
var isFilterVisible = false;
var dateValue;
var dateCheck = false;


var datagrid = {
    instance: function () {
        return $("#datagrid").dxTreeList("instance");
    },
    selectionChanged: function (selectedItems, callback) {
        var data = selectedItems.selectedRowsData[0];

        selectedStructureId = data.Id;
        if (typeof selectionChangedCallBack !== "undefined") {
            selectionChangedCallBack(data);
        }
        datagrid.reloadButtons(data);
    },

    selectionTreeListChanged: function (selectedItems, callback) {
        var data = selectedItems.currentSelectedRowKeys[0];
        selectedStructureId = data;
        if (typeof selectionChangedCallBack !== "undefined") {
            selectionChangedCallBack(data);
        }

    },

    reload: function () {
        $("#datagrid").dxTreeList("getDataSource").reload();
    },

    reloadButtons: function (data) {
        if (selectedId) {
            $("#btnEmployeeCard").prop("disabled", false);
        } else {
            $("#btnEmployeeCard").prop("disabled", true);
        }
    },

    filter: function () {
        var dataGrid = $("#datagrid").dxTreeList("instance");
        dataGrid.clearFilter();
        if (isFilterVisible) {
            dataGrid.option("filterRow.visible", true);
            isFilterVisible = false;
        }
        else {
            dataGrid.option("filterRow.visible", false);
            isFilterVisible = true;
        }
    }
};


var dtGrid = {
    instance: function () {
        return $("#dt-grid").dxDataGrid("instance");
    },
    selectionChangedForWorkFlow: function (selectedItems, callback) {
        $("#btnEdit").prop("disabled", true);
        $("#btnRemove").prop("disabled", true);
        $("#btnExecute").prop("disabled", true);
        var data = selectedItems.selectedRowsData[0];

        selectedId = data.Id;
        workId = data.WorkId;
        flowId = data.FlowId;
        canEdit = data.CanEdit;
        canDelete = data.CanDelete;
        canPrint = data.CanPrint;
        productType = data.ProductType;
        operation = data.CanExecute;
        docType = data.DocTypes;



        if (operation) {
            $("#btnEdit").prop("disabled", !canEdit);
            $("#btnRemove").prop("disabled", !canDelete);
            $("#btnExecute").prop("disabled", false);
        }
        else {
            $("#btnEdit").prop("disabled", true);
            $("#btnRemove").prop("disabled", true);
            $("#btnExecute").prop("disabled", true);
        }

        if (typeof selectionChangedCallBack !== "undefined") {
            selectionChangedCallBack(data);
        }
        dtGrid.reloadButtons(data);
    },

    selectionChangedForAssignedWorkFlow: function (selectedItems, callback) {
        $("#btnExecute").prop("disabled", true);
        $("#btnEdit").prop("disabled", true);
        $("#btnRemove").prop("disabled", true);
        var data = selectedItems.selectedRowsData[0];
        selectedId = data.ProductId;
        workId = data.WorkId;
        flowId = data.FlowId;
        canEdit = data.CanEdit;
        canDelete = data.CanDelete;
        canPrint = data.CanPrint;
        productType = data.ProductType;
        operation = data.CanExecute;
        productId = data.ProductId;

        if (operation) {
            $("#btnEdit").prop("disabled", !canEdit);
            $("#btnRemove").prop("disabled", !canDelete);
            $("#btnExecute").prop("disabled", false);
        }
        else {
            $("#btnExecute").prop("disabled", true);
        }

        if (typeof selectionChangedCallBack !== "undefined") {
            selectionChangedCallBack(data);
        }
        dtGrid.reloadButtons(data);
    },


    selectionChanged: function (selectedItems, callback) {
        var data = selectedItems.selectedRowsData[0];

        selectedId = data.Id;
        dateValue = data.YearAndMonth;
        if (!dateCheck) {
            var d = new Date();
            d.setDate(1);
            d.setMonth(d.getMonth() - 1);
            var lastMonth = new Date(d);
            var lastMonthLocaleString = lastMonth.toLocaleDateString();
            var sqlLastMonth= new Date(dateValue);
            var sqlLastMonthLocaleString = sqlLastMonth.toLocaleDateString();
            if (lastMonthLocaleString == sqlLastMonthLocaleString) {
                dateCheck = true;
            }
        }
        if (typeof selectionChangedCallBacks !== "undefined") {
            selectionChangedCallBacks(data);
        }
        dtGrid.reloadButtons(data);
    },

    selectionTreeListChanged: function (selectedItems, callback) {
        var data = selectedItems.currentSelectedRowKeys[0];
        selectedId = data;
        if (typeof selectionChangedCallBack !== "undefined") {
            selectionChangedCallBack(data);
        }

    },

    reload: function () {
        $("#dt-grid").dxDataGrid("getDataSource").reload();
    },


    reloadButtons: function (data) {

        if (selectedId) {
            $("#btnEmployeeCard").prop("disabled", false);
        } else {
            $("#btnEmployeeCard").prop("disabled", true);
        }
        if (selectedId) {
            $("#operations").prop("disabled", false);
        } else {
            $("#operations").prop("disabled", true);
        }
        if (selectedId) {
            $("#btnShow").prop("disabled", false);
        } else {
            $("#btnShow").prop("disabled", true);
        }
        if (dateCheck) {
            $("#btnCalculate").prop("disabled", false);
        } else {
            $("#btnCalculate").prop("disabled", true);
        }
        dateCheck = false;
        if (selectedId) {
            $("#btnRemove").prop("disabled", false);
        } else {
            $("#btnRemove").prop("disabled", true);
        }

        if (selectedId) {
            $("#btnEdit").prop("disabled", false);
        } else {
            $("#btnEdit").prop("disabled", true);
        }
    },

    filter: function () {
        var dataGrid = $("#dt-grid").dxDataGrid("instance");
        dataGrid.clearFilter();
        if (isFilterVisible) {
            dataGrid.option("filterRow.visible", true);
            isFilterVisible = false;
        }
        else {
            dataGrid.option("filterRow.visible", false);
            isFilterVisible = true;
        }
    }
};


var dtGridForEmployee = {
    instance: function () {
        return $("#alternatelyGrid").dxDataGrid("instance");
    },

    selectionChanged: function (selectedItems, callback) {
        var data = selectedItems.selectedRowsData[0];
        selectedAbsolutelyId = data.EmployeeId;
        selectedAbsolutelyGridId = data.Id;
        if (typeof selectionChangedCallBacks !== "undefined") {
            selectionChangedCallBacks(data);
        }
    },

    reload: function () {
        $("#alternatelyGrid").dxDataGrid("getDataSource").reload();
    },
};