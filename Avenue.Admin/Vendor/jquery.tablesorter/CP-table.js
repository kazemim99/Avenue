//Click on the headers and you'll see that your table is now sortable! You can also pass in configuration options when you initialize the table. This tells tablesorter to sort on the first and second column in ascending order.
//  مثال برای سورت بر اساس ستون ==> $("#myTable").tablesorter( {sortList: [[0,0], [1,0]]} );
$(document).ready(function () {
    $(".CP-table").tablesorter();
    //$('.CP-table').filterTable();  apply filterTable to tables with Class CP-table on this page
    $('.filter-table input').addClass("form-control input-sm");

});
