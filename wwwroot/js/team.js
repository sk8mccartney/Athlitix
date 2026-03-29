$('.team-btn').on('click', function () {
    var id = $(this).data('id');
    $('#team-id').val(id);

    if (id === '00000000-0000-0000-0000-000000000000') {
        $('#team-name').val('');
        $('#team-description').val('');
    } else {
        $.getJSON('/api/team/' + id, function (json) {
            $('#team-name').val(json.name);
            $('#team-description').val(json.description);
        });
    }
});

$('#team-submit-btn').on('click', function () {
    var id = $('#team-id').val();
    var name = $('#team-name').val();
    var description = $('#team-description').val();

    if (!name || !description) {
        Swal.fire({
            title: 'Missing information!',
            text: 'Name and Description are required!',
            icon: 'warning',
        });

        return;
    }

    var request = {
        id: id,
        name: $('#team-name').val(),
        description: $('#team-description').val(),
        organizationId: $('#organization-id').val()
    };

    $.ajax({
        url: '/api/team/save',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(request),
        success: function (response) {
            $('#modal-team').modal('hide');

            Swal.fire({
                icon: 'success',
                title: 'Your team has been saved',
                showConfirmButton: false,
                timer: 1500,
            });

            setTimeout(() => location.reload(), 1500);
        },
        error: function (err) {
            $('#modal-team').modal('hide');

            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Something went wrong! Your team has not been saved, try again.',
            });
        }
    });
});

$('.team-delete-btn').on('click', function () {
    var id = $(this).data('id');

    Swal.fire({
        title: 'Are you sure?',
        text: 'You won\'t be able to revert this!',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes, delete it!',
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: '/api/team/' + id,
                type: 'DELETE',
                success: function () {
                    Swal.fire({
                        title: 'Deleted!',
                        text: 'Your file has been deleted.',
                        icon: 'success',
                        timer: 1500,
                    });

                    setTimeout(() => location.reload(), 1500);
                },
                error: function (xhr) {
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops...',
                        text: 'Something went wrong! We could not delete this team, try again.',
                    });
                }
            });
        }
    });
});

