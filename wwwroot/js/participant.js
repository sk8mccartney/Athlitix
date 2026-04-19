$('.participant-btn').on('click', function () {
    var id = $(this).data('id');
    $('#participant-id').val(id);

    if (id === '00000000-0000-0000-0000-000000000000') {
        $('#participant-first-name').val('');
        $('#participant-last-name').val('');
        $('#participant-nick-name').val('');
        $('#participant-email').val('');
        $('#participant-phone-number').val('');
        $('#participant-date-of-birth').val(new Date().toISOString().substring(0, 10));
        $('#participant-gender').val('Male');
        $('#participant-has-medical-clearance').prop("checked", true);
        $('#participant-weight-kg').val('');
        $('#participant-height-cm').val('');
        $('#participant-record').val('');
        $('#participant-notes').val('');
    } else {
        $.getJSON('/api/participant/' + id, function (json) {
            $('#participant-team-id').val(json.teamId.toString());
            $('#participant-first-name').val(json.firstName);
            $('#participant-last-name').val(json.lastName);
            $('#participant-nick-name').val(json.nickName);
            $('#participant-email').val(json.email);
            $('#participant-phone-number').val(json.phoneNumber);
            $('#participant-date-of-birth').val(json.dateOfBirth.substring(0, 10));
            $('#participant-gender').val(json.gender);
            $('#participant-has-medical-clearance').prop("checked", json.hasMedicalClearance);
            $('#participant-weight-kg').val(json.weightKg);
            $('#participant-height-cm').val(json.heightCm);
            $('#participant-record').val(json.record);
            $('#participant-notes').val(json.notes);
        });
    }
});

$('#participant-submit-btn').on('click', function () {
    var id = $('#participant-id').val();
    var firstName = $('#participant-first-name').val();
    var lastName = $('#participant-last-name').val();
    var email = $('#participant-email').val();

    if (!firstName || !lastName || !email) {
        Swal.fire({
            title: 'Missing information!',
            text: 'First Name, Last Name and Email are required!',
            icon: 'warning',
        });

        return;
    }

    var weightKg = parseFloat($('#participant-weight-kg').val());
    var heightCm = parseFloat($('#participant-height-cm').val());

    if (isNaN(weightKg) || isNaN(heightCm)) {
        Swal.fire({
            title: 'Invalid information!',
            text: 'Weight and Height must be a numerical value!',
            icon: 'warning',
        });
        return;
    }

    var request = {
        id: id,
        teamId: $('#participant-team-id').val(),
        firstName: $('#participant-first-name').val(),
        lastName: $('#participant-last-name').val(),
        nickName: $('#participant-nick-name').val(),
        email: $('#participant-email').val(),
        phoneNumber: $('#participant-phone-number').val(),
        dateOfBirth: $('#participant-date-of-birth').val(),
        gender: $('#participant-gender').val(),
        hasMedicalClearance: $('#participant-has-medical-clearance').prop("checked"),
        weightKg: $('#participant-weight-kg').val(),
        heightCm: $('#participant-height-cm').val(),
        record: $('#participant-record').val(),
        notes: $('#participant-notes').val(),
        organizationId: $('#organization-id').val()
    };

    console.log('Request: ', request);

    $.ajax({
        url: '/api/participant/save',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(request),
        success: function () {
            $('#modal-participant').modal('hide');

            Swal.fire({
                icon: 'success',
                title: 'Your participant has been saved',
                showConfirmButton: false,
                timer: 1500,
            });

            setTimeout(() => location.reload(), 1500);
        },
        error: function (err) {
            $('#modal-participant').modal('hide');

            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Something went wrong! Your participant has not been saved, try again.',
            });
        }
    });
});

$('.participant-delete-btn').on('click', function () {
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
                url: '/api/participant/' + id,
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
                        text: 'Something went wrong! We could not delete this participant, try again.',
                    });
                }
            });
        }
    });
});

$('#filter-team-id').on('change', function () {
    var id = $(this).val();

    if (!id) return;

    window.location.href = "/participant?teamId=" + encodeURIComponent(id);
});