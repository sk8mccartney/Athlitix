$('.competition-button').on('click', function () {
    var id = $(this).data('id');

    $('#competition-id').val(id);

    if (id === '00000000-0000-0000-0000-000000000000') {
        console.log('Creating a new competition');

        $('#competition-name').val('');
        $('#competition-description').val('');
        $('#competition-start-date').val(new Date().toISOString().substring(0, 10));
        $('#competition-start-time').val('20:00');
    } else {
        console.log('Editing a competition');

        $.getJSON('/api/competition/' + id, function (json) {
            console.log('Response: ', json);

            $('#competition-name').val(json.name);
            $('#competition-description').val(json.description);
            $('#competition-start-date').val(json.startDate.substring(0, 10));
            $('#competition-start-time').val(json.startDate.substring(11, 16));
        });
    }
});

$('#competition-submit').on('click', function () {
    console.log('Saving a competition');

    var id = $('#competition-id').val();

    var request = {
        id: id,
        name: $('#competition-name').val(),
        description: $('#competition-description').val(),
        startDate: $('#competition-start-date').val(),
        startTime: $('#competition-start-time').val(),
        organizationId: $('#organization-id').val()
    };

    console.log('Competition body: ', request);

    $.ajax({
        url: '/api/competition/save',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(request),
        success: function (response) {
            console.log('Success:', response);
            $('#modal-competition').modal('hide');

            Swal.fire({
                icon: "success",
                title: "Your competition has been saved",
                showConfirmButton: false,
                timer: 1500,
            });

            setTimeout(() => location.reload(), 1500);
        },
        error: function (err) {
            console.error('Error:', err);
            $('#modal-competition').modal('hide');

            Swal.fire({
                icon: "error",
                title: "Oops...",
                text: "Something went wrong! Your competition has not been saved, try again.",
            });
        }
    });
});

