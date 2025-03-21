var dataTable;
$(document).ready(function () {
    loaddatatable();
});
function loaddatatable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/product/getall'
        },
        "columns": [
            
            { data: 'productName', "width": "20%" },
            { data: 'description', "width": "25%" },
            { data: 'brand', "width": "10%" },
            { data: 'price', "width": "5%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                    <a href="/admin/product/Upsert?id=${data}" class="btn btn-primary text-white mx-2" style="cursor:pointer;"><i class="bi bi-pencil"></i> Edit</a>
                    <a onClick=Delete('/admin/product/delete?id=${data}') class="btn btn-danger text-white mx-2" style="cursor:pointer;"><i class="bi bi-trash"></i> Delete</a>
                    </div>`
            } , "width": "25%" }
            
        ]
    });
}
function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toaster.success(data.message);
                }
            })

        };
    })
}