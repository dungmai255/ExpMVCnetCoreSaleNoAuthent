var columns = [
	{
		"render": function (data, type, row) {
			if (row == null) row = '';
			return '<img style="height:150px;width:150px" src="\\' + row.image + '"/>';
		}, "title": 'Actions', "width": "15%", "autoWidth": true, "title": 'Image'},
	{ "data": "name", "name": "name", "autoWidth": true, "title": 'Name'},
	{ "data": "phone", "name": "phone", "autoWidth": true, "title": 'Phone'},
	{ "data": "birthday", "name": "birthday", "autoWidth": true, "title": 'Birthday'},
	{ "data": "address", "name": "address", "autoWidth": true, "title": 'Address'},
];

columns.push({
	"render": function (row, type, row) {
		if (row == null) row = '';
		return '<a href="#" class="btn btn-link btn-info btn-just-icon like"><i class="material-icons">favorite</i></a><a href="#" data-toggle="modal" data-target="#info_modal" class="btn btn-link btn-warning btn-just-icon edit"><i class="material-icons">dvr</i></a><a href="#" class="btn btn-link btn-danger btn-just-icon remove"><i class="material-icons">close</i></a>';
	}, "title": 'Actions', "width" : "15%"
});

$(document).ready(function () {
	//draw modal
    var modal = $("#info_modal");
    var modal_title = $("#info_modalLabel");
    var modal_body = $(modal).find("div.modal-body");
    var modal_footer = $(modal).find("div.modal-footer");

    $(modal_title).text("Cập nhật người dùng");
    $(modal_footer).html(
        '<button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>'
        + '<button type="button" class="btn btn-success" id="btn_Save">Lưu</button >'
    );

    $(modal_body).html(
                   '<div class="container-fluid">'
                +       '<div class="row">'
                +           '<div class="col-md-4">'
                +				'<div class="form-group col-md-12 text-center">'
				+					'<div class="fileinput fileinput-new text-center" data-provides="fileinput">'
				+					'    <div class="fileinput-new thumbnail img-circle">'
				+					'        <img id="user-image" src="/img/placeholder.jpg" alt="...">'
				+					'        <input id="user-img" type="hidden">'
				+					'    </div>'
				+					'    <div class="fileinput-preview fileinput-exists thumbnail img-circle" style=""></div>'
				+					'    <div>'
				+					'        <span class="btn btn-round btn-rose btn-file">'
				+					'            <span class="fileinput-new">Add Photo</span>'
				+					'            <span class="fileinput-exists">Change</span>'
				+					'            <input type="hidden"><input id="user-avata" type="file" name="...">'
				+					'            <div class="ripple-container"></div>'
				+					'        </span>'
				+					'        <br>'
				+					'        <a href="#pablo" class="btn btn-danger btn-round fileinput-exists" data-dismiss="fileinput"><i class="fa fa-times"></i> Remove</a>'
				+					'    </div>'
				+					'</div>'
                +				'</div>'
                +           '</div>'
                +           '<div class="form-group col-md-8">'
                +				'<div class="form-group col-md-12">'
                +					'<label for="user-name" class="col-form-label">Name:</label>'
                +					'<input type="text" class="form-control" id="user-name">'
                +				'</div>'
                +				'<div class="form-group col-md-12">'
                +					'<label for="user-phone" class="col-form-label">Phone:</label>'
                +					'<input type="text" class="form-control" id="user-phone">'
                +				'</div>'
                +				'<div class="form-group col-md-12">'
                +					'<label for="user-dob" class="col-form-label">Birthday:</label>'
                +					'<input type="date" class="form-control" id="user-dob">'
                +				'</div>'
                +				'<div class="form-group col-md-12">'
                +					'<label for="user-address" class="col-form-label">Address:</label>'
                +					'<input type="text" class="form-control" id="user-address">'
                +					'<input type="hidden" id="user-id"/>'
                +				'</div>'
                +				'<div class="form-group col-md-12">'
                +					'<label for="user-type" class="col-form-label">Type:</label>'
                +					'<input type="text" class="form-control" id="user-type">'
                +				'</div>'
                +           '</div>'
                +       '</div>'
                +   '</div>'
    );
   //end draw modal

	//datatable
	table = $("#tbl_data").DataTable({
		"language": {
			search: "_INPUT_",
			searchPlaceholder: "Search records",
		},
		"pagingType": "full_numbers",
		"lengthMenu": [
			[15, 25, 50, -1],
			[15, 25, 50, "All"]
		],
		"responsive": true,
		"processing": true,
		"serverSide": true,
		"filter": false,
		"orderMulti": false,
		"ajax": {
			url: "/User/Load",
			type: "POST",
			//datatype: "json",
			data: function () {
				var formData = new FormData();
				formData.append("id", $("#user-id").val());
				formData.append("name", $("#user-name").val());
				formData.append("phone", $("#user-phone").val());
				formData.append("dob", $("#user-dob").val());
				formData.append("address", $("#user-address").val());
				formData.append("type", $("#user-type").val());
				
				return formData;
			},
			contentType: false,
			processData: false,
		},
		"columnDefs":
			[{
				"targets": '_all',
				"render": $.fn.dataTable.render.text(),
				"searchable": true,
				"orderable": true,
			},
				{
					"targets": "-1",
					"className": 'dt-body-canter'
				}],
		"columns": columns,
	});
	//end initial datatable

	//add user 
    $("#btn_AddUser").on("click", function () {
		$('#info_modal').modal('show');
		$("#user-name").val("");
		$("#user-dob").val("");
		$("#user-phone").val("");
		$("#user-address").val("");
		$("#user-id").val("");
		$("#user-type").val("");
		$("a.fileinput-exists").click();
		$("#user-image").attr("src", "/img/placeholder.jpg");
	})
    $("#btn_AddUser").on("mouseover", function () {
		$(this).css("cursor", "pointer");
    })
	//end add user

	//add event for save button
    $("#btn_Save").click(function () {
        var formData = new FormData;
		formData.append("id", $("#user-id").val());
        formData.append("name", $("#user-name").val());
        formData.append("phone", $("#user-phone").val());
        formData.append("dob", $("#user-dob").val());
        formData.append("address", $("#user-address").val());
		formData.append("image", $("#user-img").val());
		formData.append("type", $("#user-type").val());
		var files = document.getElementById("user-avata").files;
		if (files != "undefined" && files.length > 0) {
			var file = files[0];
			formData.append("image", file);
		}

        $.ajax({
            url: "/User/Edit/",
            method: "POST",
            data: formData,
            processData: false,
            contentType: false,
            success: function () {
				$('#info_modal').modal('hide');
				$("#btn_AddUser").click();
                table.draw();
            },
            error: function (e) {
                console.log(e.responseText);
            }
        });
	});
	//end add event for save button

	//get data for detail modal
	$('#tbl_data tbody').on('click', 'tr', function () {
		var data = table.row($(this)).data();
		$("#user-name").val(data["name"]);
		$("#user-dob").val(data["birthday"]);
		$("#user-phone").val(data["phone"]);
		$("#user-address").val(data["address"]);
		$("#user-id").val(data["id"]);
		$("#user-img").val(data["image"]);
		$("#user-image").attr("src", data["image"]);
		$("#user-type").attr("src", data["type_id"]);
	});
	//end get data for detail modal
});

function validateStringNotNull(e) {
	return $(e).val() != "" || $(e).text() != ""
}

function validate(e) {
	if (!validateStringNotNull(e)) {
		$("#message").css("color", "red").text("Nhập thông tin");
		$(e).focus();
		return false;
	} else {
		$("#message").css("color", "red").text("");
	}
	return true;
}