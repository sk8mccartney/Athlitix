$('.event-btn').on('click', function () {
    var id = $(this).data('id');
    $('#event-id').val(id);

    if (id === '00000000-0000-0000-0000-000000000000') {
        $('#event-name').val('');
        $('#event-description').val('');
        $('#event-start-date').val(new Date().toISOString().substring(0, 10));
        $('#event-start-time').val('20:00');
    } else {
        $.getJSON('/api/event/' + id, function (json) {
            $('#event-name').val(json.name);
            $('#event-description').val(json.description);
            $('#event-start-date').val(json.startDate.substring(0, 10));
            $('#event-start-time').val(json.startDate.substring(11, 16));
        });
    }
});

$('#event-submit-btn').on('click', function () {
    var id = $('#event-id').val();
    var name = $('#event-name').val();
    var description = $('#event-description').val();

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
        name: $('#event-name').val(),
        description: $('#event-description').val(),
        startDate: $('#event-start-date').val(),
        startTime: $('#event-start-time').val(),
        organizationId: $('#organization-id').val()
    };

    $.ajax({
        url: '/api/event/save',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(request),
        success: function (response) {
            $('#modal-event').modal('hide');

            Swal.fire({
                icon: 'success',
                title: 'Your event has been saved',
                showConfirmButton: false,
                timer: 1500,
            });

            setTimeout(() => location.reload(), 1500);
        },
        error: function (err) {
            $('#modal-event').modal('hide');

            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Something went wrong! Your event has not been saved, try again.',
            });
        }
    });
});

$('.event-delete-btn').on('click', function () {
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
                url: '/api/event/' + id,
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
                        text: 'Something went wrong! We could not delete this event, try again.',
                    });
                }
            });
        }
    });
});

