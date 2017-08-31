//==================AttributeValue add Nav====================
if ($(window).width() < 890) {
    function openAttributeValueNav(id) {

        document.getElementById("AttributeValueSidenav").style.width = "100%";
        $("#AttributeValueSidenav").parent().addClass("sidenav-overlay");
        $("#instokid").val(id);
    }
}
else {
    function openAttributeValueNav(id) {
        document.getElementById("AttributeValueSidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#AttributeValueSidenav").parent().addClass("sidenav-overlay");
        $("#instokid").val(id);
    }
}
function openAttributeValueNav(id) {
    document.getElementById("AttributeValueSidenav").style.width = "0";
    $("#AttributeValueSidenav").parent().removeClass("sidenav-overlay");
    $("#instokid").val(id);

}
//==================AttributeValue Edit Nav====================
if ($(window).width() < 890) {
    function openAttributeValueEditNav(id) {
        $.ajax({
            url: "/CategoryAttributeValues/GetEdit",
            data: { Id: id },
            type: "Get",
            dataType: "Html",
            success: function (Data) {
                $(".DivPartialEdit").html(Data);
                document.getElementById("AttributeValueEditSidenav").style.width = "100%";
                $("#AttributeValueEditSidenav").parent().addClass("sidenav-overlay");
            },
            error: function () {
             
                $.notify("خطا", "danger");
            }
        });
    }
}
else {
    function openAttributeValueEditNav(id) {
        $.ajax({
            url: "/CategoryAttributeValues/GetEdit",
            data: { Id: id },
            type: "Get",
            dataType: "Html",
            success: function (Data) {
                $(".DivPartialEdit").html(Data);
                document.getElementById("AttributeValueEditSidenav").style.width = "50%";
                $("#AttributeValueEditSidenav").parent().addClass("sidenav-overlay");
            },
            error: function () {

                $.notify("خطا", "danger");
            }
        });
   
      
    }
}
function openAttributeValueEditNav(id) {
    $.ajax({
        url: "/CategoryAttributeValues/GetEdit",
        data: { Id: id },
        type: "Get",
        dataType: "Html",
        success: function (Data) {
            $(".DivPartialEdit").html(Data);
            document.getElementById("AttributeValueEditSidenav").style.width = "0";
            $("#AttributeValueEditSidenav").parent().addClass("sidenav-overlay");
        },
        error: function () {

            $.notify("خطا", "danger");
        }
    });


}
//==================Filter Nav====================
if ($(window).width() < 890) {
    function openFilterNav() {

        document.getElementById("FilterSidenav").style.width = "100%";
        $("#FilterSidenav").parent().addClass("sidenav-overlay");
      
    }
}
else {
    function openFilterNav() {
        document.getElementById("FilterSidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#FilterSidenav").parent().addClass("sidenav-overlay");
      
    }
}
function closeFilterNav() {
    document.getElementById("FilterSidenav").style.width = "0";
    $("#FilterSidenav").parent().removeClass("sidenav-overlay");

}
//============================Edit nav========================
if ($(window).width() < 890) {
    function openNav() {
        document.getElementById("EditSidenav").style.width = "100%";
        $("#EditSidenav").parent().addClass("sidenav-overlay");
    }
}
else {
    function openNav() {
        document.getElementById("EditSidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#EditSidenav").parent().addClass("sidenav-overlay");
    }
}
function closeNav() {
    document.getElementById("EditSidenav").style.width = "0";
    $("#EditSidenav").parent().removeClass("sidenav-overlay");
}
//========================== Add Nav=========================
if ($(window).width() < 890) {
    function openAddNav() {
        document.getElementById("AddSidenav").style.width = "100%";
        $("#AddSidenav").parent().addClass("sidenav-overlay");
    }
}
else {
    function openAddNav() {
        document.getElementById("AddSidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#AddSidenav").parent().addClass("sidenav-overlay");
    }
}
function closeAddNav() {
    document.getElementById("AddSidenav").style.width = "0";
    $("#AddSidenav").parent().removeClass("sidenav-overlay");
}
//========================== Sort Nav=========================
if ($(window).width() < 890) {
    function openSortNav() {
        document.getElementById("SortSidenav").style.width = "100%";
        $("#SortSidenav").parent().addClass("sidenav-overlay");
    }
}
else {
    function openSortNav() {
        document.getElementById("SortSidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#SortSidenav").parent().addClass("sidenav-overlay");
    }
}
function closeSortNav() {
    document.getElementById("SortSidenav").style.width = "0";
    $("#SortSidenav").parent().removeClass("sidenav-overlay");
}


//========================== upload Nav=========================
if ($(window).width() < 890) {
    function openUploadNav() {
        document.getElementById("uploadSidenav").style.width = "100%";
        $("#uploadSidenav").parent().addClass("sidenav-overlay");
    }
}
else {
    function openUploadNav() {
        document.getElementById("uploadSidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#uploadSidenav").parent().addClass("sidenav-overlay");
    }
}
function closeUploadNav() {
    document.getElementById("uploadSidenav").style.width = "0";
    $("#uploadSidenav").parent().removeClass("sidenav-overlay");
}


//========================== upload Nav=========================
if ($(window).width() < 890) {
    function openCategoryNav() {
        document.getElementById("CategorySidenav").style.width = "100%";
        $("#CategorySidenav").parent().addClass("sidenav-overlay");
    }
}
else {
    function openCategoryNav() {
        document.getElementById("CategorySidenav").style.width = "50%";
        //document.getElementsByTagName('body').className += ' sidenav-overlay';
        $("#CategorySidenav").parent().addClass("sidenav-overlay");
    }
}
function closeCategoryNav() {
    document.getElementById("CategorySidenav").style.width = "0";
    $("#CategorySidenav").parent().removeClass("sidenav-overlay");
}

