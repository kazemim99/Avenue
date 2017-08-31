
$("btnEditMeterial").hide();
////////////////NEXT Step2////////////////////
$("#btnsaveMeterial").click(function (e) {
    e.preventDefault();
    $("#Resepi_material_id").val(0);
    $("#Resepi_material_content_id").val(0);
    var dataform = new window.FormData($("#Step2_Form")[0]);
    if ($("#Step2_Form").valid()) {
        $.ajax({
            xhr: function () {
                return $.ajaxSettings.xhr();
            },
            url: "/Recipe/AddMeterial",
            contentType: false,
            processData: false,
            dataType: 'json',
            type: 'Post',
            data: dataform,
            success: function (result) {
                if (result.Success) {
                    $.ajax({
                        url: "/Recipe/GetMeterialGrid",
                        data: { Id: result.Id },
                        type: "Post",
                        dataType: "Html",
                        success: function (Data) {
                            $("tbody.step2_2").html(Data);
                            $('#Resepi_Material_Content_Amount').val('');
                            $('#Resepi_Material_Content_Description').val('');
                            $('#Unit_Content_Unit_Id').val('');
                            $('#Material_Content_Material_Id').val('');
                            $.notify("با موفقیت ثبت شد", "success");
                        }
                    });
                }
                else {
                    $.notify(result.message, "error");
                }
            },
            error: function () {
                alert("خطا!");
            }
        });
    }
});

//////////////////NEXT Step3////////////////////
function NextStep2(id) {

    $('#myTab a[href="#Recipes"]').tab('show');
    $("#EditStep").hide();
    $.ajax({
        url: "/Recipe/GetStep3",
        data: { Id: id },
        type: "Get",
        dataType: "Html",
        success: function (Data) {
            $("tbody.Step3").html(Data);

        }
    });
}

function EditMateria(id,resid) {
  
    $.ajax({
        url: "/Recipe/FindMeterial",
        dataType: 'Html',
        type: 'Post',
        data: { Id: id , ResID: resid },
        success: function (result) {
            $("#Step2").html(result);
            $("#btnsaveMeterial").hide();
            $("#btnEditMeterial").show();
        },
        error: function () {
            alert("خطا!");
        }
    });
}

$("#btnEditMeterial").click(function (e) {
    e.preventDefault();
    var dataform = new window.FormData($("#Step2_Form")[0]);
    if ($("#Step2_Form").valid()) {
        $.ajax({
            xhr: function () {
                return $.ajaxSettings.xhr();
            },
            url: "/Recipe/EditMeterial",
            contentType: false,
            processData: false,
            dataType: 'json',
            type: 'Post',
            data: dataform,
            success: function (result) {
                if (result.Success) {
                    $.ajax({
                        url: "/Recipe/GetMeterialGrid",
                        data: { Id: result.Id },
                        type: "Post",
                        dataType: "Html",
                        success: function (Data) {
                            $("tbody.step2_2").html(Data);
                            $("#btnsaveMeterial").show();
                            $("#btnEditMeterial").hide();
                            $('#Resepi_Material_Content_Amount').val('');
                            $('#Resepi_Material_Content_Description').val('');
                            $('#Unit_Content_Unit_Id').val('');
                            $('#Material_Content_Material_Id').val('');
                            $.notify("با موفقیت ویرایش شد", "success");
                        }
                    });
                }
                else {
                    $.notify(result.message, "error");
                }
            },
            error: function () {
                alert("خطا!");
            }
        });
    }
});

function DeleteMateria(rm_id, rmc_id,resepeid) {
    $.ajax({
        url: "/Recipe/DelMaterial",
        dataType: 'json',
        type: 'Post',
        data: { RM_id: rm_id, RMC_id: rmc_id },
        success: function (result) {
            if (result.Success) {
                $.ajax({
                    url: "/Recipe/GetMeterialGrid",
                    data: { Id: resepeid },
                    type: "Post",
                    dataType: "Html",
                    success: function (Data) {
                        $("tbody.step2_2").html(Data);
                        $("#btnsaveMeterial").show();
                        $("#btnEditMeterial").hide();
                        $.notify("با موفقیت حذف شد", "success");
                    }
                });
            }
            else {
                $.notify("حذف نشد", "error");
            }
        },
        error: function () {
            alert("خطا!");
        }
    });
}