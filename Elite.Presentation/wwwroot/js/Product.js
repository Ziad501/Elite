$(document).ready(function () {
    loaddatatable();
});
function loaddatatable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/product/getall'
        },
        "columns": [
            { data: 'id', "width": "5%" },
            { data: 'productName', "width": "20%" },
            { data: 'description', "width": "25%" },
            { data: 'brand', "width": "10%" },
            { data: 'price', "width": "5%" },
            { data: 'categoryId', "width": "5%" }
            
        ]
    });
}