var dataTable;
$(document).ready(function () {
    loaddatatable();
});
function loaddatatable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/Company/GetAll'
        },
        "columns": [
            
            { data: 'name', "width": "10%" },
            { data: 'city', "width": "10%" },
            { data: 'province', "width": "10%" },
            { data: 'phoneNumber', "width": "10%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                    <a href="/admin/Company/Upsert?id=${data}" class="btn btn-primary text-white mx-2" style="cursor:pointer;"><i class="bi bi-pencil"></i> Edit</a>
                    <a onClick=Delete('/admin/Company/delete?id=${data}') class="btn btn-danger text-white mx-2" style="cursor:pointer;"><i class="bi bi-trash"></i> Delete</a>
                    </div>`
            } , "width": "40%" }
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
                    toastr.success(data.message);
                }
            })

        };
    })
}