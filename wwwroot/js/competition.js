$('.competition-btn').on('click', function () {
    var id = $(this).data('id');
    $('#competition-id').val(id);

    if (id === '00000000-0000-0000-0000-000000000000') {
        $('#competition-name').val('');
        $('#competition-description').val('');
        $('#competition-start-date').val(new Date().toISOString().substring(0, 10));
        $('#competition-start-time').val('20:00');
    } else {
        $.getJSON('/api/competition/' + id, function (json) {
            $('#competition-name').val(json.name);
            $('#competition-description').val(json.description);
            $('#competition-start-date').val(json.startDate.substring(0, 10));
            $('#competition-start-time').val(json.startDate.substring(11, 16));
        });
    }
});

$('#competition-submit-btn').on('click', function () {
    var id = $('#competition-id').val();
    var name = $('#competition-name').val();
    var description = $('#competition-description').val();

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
        name: $('#competition-name').val(),
        description: $('#competition-description').val(),
        startDate: $('#competition-start-date').val(),
        startTime: $('#competition-start-time').val(),
        organizationId: $('#organization-id').val()
    };

    $.ajax({
        url: '/api/competition/save',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(request),
        success: function (response) {
            $('#modal-competition').modal('hide');

            Swal.fire({
                icon: 'success',
                title: 'Your competition has been saved',
                showConfirmButton: false,
                timer: 1500,
            });

            setTimeout(() => location.reload(), 1500);
        },
        error: function (err) {
            $('#modal-competition').modal('hide');

            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Something went wrong! Your competition has not been saved, try again.',
            });
        }
    });
});

$('.competition-delete-btn').on('click', function () {
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
                url: '/api/competition/' + id,
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
                        text: 'Something went wrong! We could not delete this competition, try again.',
                    });
                }
            });
        }
    });
});

