// Demo datatables
// -----------------------------------
$(document).ready(function () {
    $('.datatable-X').DataTable();
});
$(document).ready(function () {
    $('.datatable-date-sorted').DataTable({
        "order": [[7, "desc"]]
    });
});
$(document).ready(function () {
    $('.datatable-date-sorted-1').DataTable({
        "order": [[1, "desc"]]
    });
});
$(document).ready(function () {
    $('.datatable-date-sorted-2').DataTable({
        "order": [[3, "desc"]]
    });
});
$(document).ready(function () {
    $('.datatable-date-sorted-3').DataTable({
        "order": [[2, "desc"]]
    });
});

$(document).ready(function () {
    $('.datatable-date-sorted-4').DataTable({
        "order": [[4, "asc"]]
    });
});
$(document).ready(function () {
    $('.datatable-rowReorder').DataTable({
        rowReorder: true,
        columnDefs: [
                    { orderable: true, className: 'reorder', targets: 0 },
                    { orderable: false, targets: '_all' }
        ]
    });
});

(function (window, document, $, undefined) {

    $(function () {

        if (!$.fn.dataTable) return;

        //
        // Zero configuration
        //

        $('#datatable1').dataTable({
            'paging': true,  // Table pagination
            'ordering': true,  // Column ordering
            'info': true,  // Bottom left status text
            'responsive': true, // https://datatables.net/extensions/responsive/examples/
            // Text translation options
            // Note the required keywords between underscores (e.g _MENU_)
            oLanguage: {
                sSearch: 'جستجو',
                sLengthMenu: '_MENU_آیتم در صفحه',
                info: 'Showing page _PAGE_ of _PAGES_',
                zeroRecords: 'Nothing found - sorry',
                infoEmpty: 'No records available',
                infoFiltered: '(filtered from _MAX_ total records)'
            },
            // Datatable Buttons setup
            dom: '<"html5buttons"B>lTfgitp',
            buttons: [
                { extend: 'copy', className: 'btn-sm' },
                { extend: 'csv', className: 'btn-sm' },
                { extend: 'excel', className: 'btn-sm', title: 'XLS-File' },
                { extend: 'pdf', className: 'btn-sm', title: $('title').text() },
                { extend: 'print', className: 'btn-sm' }
            ]
        });
        //
        // Filtering by Columns
        //

        var dtInstance2 = $('#datatable2').dataTable({
            'paging': true,  // Table pagination
            'ordering': true,  // Column ordering
            'info': true,  // Bottom left status text
            'responsive': true, // https://datatables.net/extensions/responsive/examples/
            // Text translation options
            // Note the required keywords between underscores (e.g _MENU_)
            oLanguage: {
                sSearch: 'جستجو',
                sLengthMenu: '_MENU_آیتم در صفحه',
                info: 'Showing page _PAGE_ of _PAGES_',
                zeroRecords: 'Nothing found - sorry',
                infoEmpty: 'No records available',
                infoFiltered: '(filtered from _MAX_ total records)'
            }
        });
        var inputSearchClass = 'datatable_input_col_search';
        var columnInputs = $('tfoot .' + inputSearchClass);

        // On input keyup trigger filtering
        columnInputs
          .keyup(function () {
              dtInstance2.fnFilter(this.value, columnInputs.index(this));
          });


        //
        // Column Visibilty Extension
        //

        $('#datatable3').dataTable({
            'paging': true,  // Table pagination
            'ordering': true,  // Column ordering
            'info': true,  // Bottom left status text
            'responsive': true, // https://datatables.net/extensions/responsive/examples/
            // Text translation options
            // Note the required keywords between underscores (e.g _MENU_)
            oLanguage: {
                sSearch: 'جستجو',
                sLengthMenu: '_MENU_آیتم در صفحه',
                info: 'Showing page _PAGE_ of _PAGES_',
                zeroRecords: 'Nothing found - sorry',
                infoEmpty: 'No records available',
                infoFiltered: '(filtered from _MAX_ total records)'
            },
            // set columns options
            'aoColumns': [
                { 'bVisible': false },
                { 'bVisible': true },
                { 'bVisible': true },
                { 'bVisible': true },
                { 'bVisible': true }
            ],
            sDom: 'C<"clear">lfrtip',
            colVis: {
                order: 'alfa',
                'buttonText': 'Show/Hide Columns'
            }
        });

        //
        // AJAX
        //

        $('#datatable4').dataTable({
            'paging': true,  // Table pagination
            'ordering': true,  // Column ordering
            'info': true,  // Bottom left status text
            'responsive': true, // https://datatables.net/extensions/responsive/examples/
            sAjaxSource: '/Content/Json/datatable.json',
            aoColumns: [
              { mData: 'engine' },
              { mData: 'browser' },
              { mData: 'platform' },
              { mData: 'version' },
              { mData: 'grade' }
            ]
        });
    });

})(window, document, window.jQuery);
