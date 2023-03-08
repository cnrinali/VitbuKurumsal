$(function () {
    $('#example').DataTable({
        "paging": true,
        "lengthChange": true,
        "searching": true,
        "ordering": true,
        "info": true,
        "autoWidth": true,
        "scrollX": true,
        "columnDefs": [{
            "orderable": false,
            "className": "select-checkbox",
            "targets": 0
        }],
        "select": {
            "style": "os",
            "selector": "td:first-child"
        },
        "order": [[1, "asc"]]
    });
    $("select#StatuId").each(function () {
        if ($(this).val() == 1) {
            $(this).parent().parent().css("background-color", "yellow");
        }
        if ($(this).val() == 2) {
            $(this).parent().parent().css("background-color", "green");
        }
        if ($(this).val() == 3) {
            $(this).parent().parent().css("background-color", "#ab1a1a");
        }
    });
});
$("body").on("click",
    "#postaradurak:checked",
    function () {
        $('#postarasehir').show();
        $('#postarailce').show();
    });
$('#postaradurak:checked').each(function (index) {
    var postVehiclePrices = $(this).val();
    var rezervation = data.id;
    var price = $(this).data("bind");
    $.post(location.origin + "/Rezervation/Aradurak", {
        additionalServicesId: additionalServices,
        rezervationId: rezervation,
        price: price,
    }, function (data) {

    });
});
$('a#editlist').on('click', function () {
    var inputDataId = $(this).attr('data_bind');
    debugger;
    $(this).hide();
    $("#saveList[data_bind='" + inputDataId + "']").show();
    $("select[data-bind='" + inputDataId + "']").removeAttr('disabled');
    $("input[data-id='" + inputDataId + "']").removeAttr('readonly');
});

$('a#saveList').on('click', function () {
    debugger;
    var inputDataId = $(this).attr('data_bind');
    $(this).hide();
    $("a#editlist[data_bind='" + inputDataId + "']").show();
    $("select[data-bind='" + inputDataId + "']").attr('disabled', 'true');
    $("input[data-id='" + inputDataId + "']").attr('readonly', 'readonly');
    var StartSehir = $("select#StartSehir[data-bind='" + inputDataId + "']").val();
    var StartIlce = $("select#StartIlce[data-bind='" + inputDataId + "']").val();
    var StartSemtMah = $("select#StartSemtMah[data-bind='" + inputDataId + "']").val();
    var EndSehir = $("select#EndSehir[data-bind='" + inputDataId + "']").val();
    var EndIlce = $("select#EndIlce[data-bind='" + inputDataId + "']").val();
    var EndSemtMah = $("select#EndSemtMah[data-bind='" + inputDataId + "']").val();
    var StartDate = $("input#StartDate[data-id='" + inputDataId + "']").val();
    var EndDate = $("input#EndDate[data-id='" + inputDataId + "']").val();
    var PersonCount = $("input#PersonCount[data-id='" + inputDataId + "']").val();
    var DeparturePoint = $("input#DeparturePoint[data-id='" + inputDataId + "']").val();
    var Destination = $("input#Destination[data-id='" + inputDataId + "']").val();
    var Plate = $("input#Plate[data-id='" + inputDataId + "']").val();
    var Personal = $("select#Personal[data-bind='" + inputDataId + "']").val();
    var PersonalGsm = $("input#PersonalGsm[data-id='" + inputDataId + "']").val();
    var PersonalTC = $("select#PersonalTC[data-bind='" + inputDataId + "']").val();
    var CompanyId = $("select#CompanyId[data-bind='" + inputDataId + "']").val();
    var VehicleCategoryId = $("select#VehicleCategoryId[data-bind='" + inputDataId + "']").val();
    var VehicleId = $("select#VehicleId[data-bind='" + inputDataId + "']").val();
    var TotalPrice = $("input#TotalPrice[data-id='" + inputDataId + "']").val();
    var PriceId = $("input#PriceId[data-id='" + inputDataId + "']").val();
    var CustomerId = $("select#CustomerId[data-bind='" + inputDataId + "']").val();
    var UserId = $("select#UserId[data-bind='" + inputDataId + "']").val();
    var FlightCode = $("input#FlightCode[data-id='" + inputDataId + "']").val();
    var AirplaneTime = $("input#AirplaneTime[data-id='" + inputDataId + "']").val();
    var RefCode = $("input#RefCode[data-id='" + inputDataId + "']").val();
    var StatuId = $("select#StatuId[data-bind='" + inputDataId + "']").val();
    $.post(location.origin + "/Rezervation/RezervationEdit", {
        Id: inputDataId,
        StartSehir: StartSehir,
        StartIlce: StartIlce,
        StartSemtMah: StartSemtMah,
        EndSehir: EndSehir,
        EndIlce: EndIlce,
        EndSemtMah: EndSemtMah,
        StartDate: StartDate,
        EndDate: EndDate,
        PersonCount: PersonCount,
        DeparturePoint: DeparturePoint,
        Destination: Destination,
        Plate: Plate,
        Personal: Personal,
        PersonalGsm: PersonalGsm,
        PersonalTC: PersonalTC,
        VehicleCategoryId: VehicleCategoryId,
        VehicleId: VehicleId,
        TotalPrice: TotalPrice,
        PriceId: PriceId,
        UserId: UserId,
        FlightCode: FlightCode,
        AirplaneTime: AirplaneTime,
        RefCode: RefCode,
        StatuId: StatuId
    }, function (data) {
        if (data == "Başarılı!") {
            createAlert('', data, 'Düzenleme işlemi başarılı şekilde gerçekleşti', 'success', true, true, 'pageMessages');
        }
        else {
            createAlert('Hata', data, 'Düzenleme işlemi başarısız şekilde gerçekleşti', 'danger', true, false, 'pageMessages');
        }
    });
})
$('a#postmodel').on('click', function () {
    debugger;
    var StartSehir = $("select#postsehir").val();
    var StartIlce = $("select#postilce").val();
    var StartSemtMah = $("select#postsemt").val();
    var EndSehir = $("select#postendsehir").val();
    var EndIlce = $("select#postendilce").val();
    var EndSemtMah = $("select#postendsemt").val();
    var StartDate = $("input#poststartDate").val();
    var EndDate = $("input#postEndDate").val();
    var PersonCount = $("input#postPersonCount").val();
    var DeparturePoint = $("input#postDeparturePoint").val();
    var Destination = $("input#postDestination").val();
    var Plate = $("input#postPlate").val();
    var Personal = $("select#postCarrier").val();
    var PersonalGsm = $("input#postUsergsm").val();
    var PersonalTC = $("select#postUserGetTc").val();
    var VehicleCategoryId = $("select#VehicleCategoryId").val();
    var VehicleId = $("select#postPlate").val();
    var TotalPrice = $("input#postPrices").val();
    var PriceId = $("input#PriceId").val();
    var CustomerId = $("select#postCustomer").val();
    var UserId = $("select#postCarrierUser").val();
    var FlightCode = $("input#postFlightCode").val();
    var AirplaneTime = $("input#postAirplaneTime").val();
    var RefCode = $("input#postRefCode").val();
    var CompanyId = $("select#postCompany").val();
    var VehiclePrices = $("select#postVehiclePrices").val();
    var IntermediateStop = $("select#postarasehir").val() + "/" + $("select#postarailce").val();
    $.post(location.origin + "/Rezervation/RezervationAdd", {
        StartSehir: StartSehir,
        StartIlce: StartIlce,
        StartSemtMah: StartSemtMah,
        EndSehir: EndSehir,
        EndIlce: EndIlce,
        EndSemtMah: EndSemtMah,
        StartDate: StartDate,
        EndDate: EndDate,
        PersonCount: PersonCount,
        DeparturePoint: DeparturePoint,
        Destination: Destination,
        Plate: Plate,
        Personal: Personal,
        PersonalGsm: PersonalGsm,
        PersonalTC: PersonalTC,
        VehicleCategoryId: VehicleCategoryId,
        VehicleId: VehicleId,
        TotalPrice: TotalPrice,
        PriceId: PriceId,
        CustomerId: CustomerId,
        CarrierId: UserId,
        UserId: UserId,
        FlightCode: FlightCode,
        AirplaneTime: AirplaneTime,
        RefCode: RefCode,
        CompanyId: CompanyId,
        StatusId: 1,
        VehiclePrice: VehiclePrices,
        IntermediateStop: IntermediateStop
    }, function (data) {
        console.log(data);
        if (data != "Başarısız!") {
            $('#AdditionalService:checked').each(function (index) {
                var additionalServices = $(this).val();
                var rezervation = data.id;
                var price = $(this).data("bind");
                $.post(location.origin + "/Rezervation/AdditionalServicesRezervationAdd", {
                    additionalServicesId: additionalServices,
                    rezervationId: rezervation,
                    price: price,
                }, function (data) {
                    console.log(data)
                });
            });
            $("tbody#customer").children().each(function (index) {
                var postCustomerUyruk = $(this).find('input#postCustomerUyruk').val();
                var postCustomerCinsiyet = $(this).find("input#postCustomerCinsiyet:checked").val();
                var postCustomerAd = $(this).find("input#postCustomerAd").val();
                var postCustomerSoyad = $(this).find("input#postCustomerSoyad").val();
                var postCustomerEmail = $(this).find("input#postCustomerEmail").val();
                var postCustomerKimlik = $(this).find("input#postCustomerKimlik").val();
                var postCustomerPasaportNo = $(this).find("input#postCustomerPasaportNo").val();
                var postCustomerTelefon = $(this).find("input#postCustomerTelefon").val();
                var postCustomerSms = $(this).find("input#postCustomerSms").val();
                $.post(location.origin + "/superadmin/customermodaladd", {
                    RezervationId: data.id,
                    Uyruk: postCustomerUyruk,
                    Cinsiyet: postCustomerCinsiyet,
                    Ad: postCustomerAd,
                    Soyad: postCustomerSoyad,
                    KimlikNo: postCustomerKimlik,
                    PasaportNo: postCustomerPasaportNo,
                    Email: postCustomerEmail,
                    Telefon: postCustomerTelefon,
                    Sms: postCustomerSms,
                    StatusID: "1"
                }, function (data) {
                    console.log(data)
                });
            });
            createAlert('', data, 'Ekleme işlemi başarılı şekilde gerçekleşti', 'success', true, true, 'pageMessages');
            location.reload();
        }
        else
            createAlert('Hata', data, 'Ekleme işlemi başarısız şekilde gerçekleşti', 'danger', true, false, 'pageMessages');
    });
})
$("#postCarrier").change(function () {
    $("#postCarrierUser").empty();
    debugger;
    var val = $(this).val();
    var url = $("#postCarrier").data("url") + '?value=' + val;
    $.getJSON(url, function (data) {
        $("#postCarrierUser").empty();
        $("#postCarrierUser").removeAttr("disabled");
        $("#postCarrierUser").append('<option selected disabled value="">Seçiniz</option>');
        $.each(data, function (i, item) {
            console.log(item);
            $("#postCarrierUser").append($("<option>").text(item.nameSurname).val(item.id));
        });
        $("#postCarrierUser").removeAttr("disabled");
    });
    $("#postPlate").empty();
    var val = $(this).val();
    var url = location.origin + '/Rezervation/GetCompanyPlate?value=' + val;
    $.getJSON(url, function (data) {
        $("#postPlate").empty();
        $("#postPlate").removeAttr("disabled");
        $("#postPlate").append('<option selected disabled value="">Seçiniz</option>');
        $.each(data, function (i, item) {
            console.log(item);
            $("#postPlate").append($("<option>").text(item.vehiclePlate).val(item.id)).attr("data-bind", item.vehiclePlate);
        });
        $("#postPlate").removeAttr("disabled");
    });
});
$("#postarasehir").change(function () {
    $("#postarailce").empty();
    var v = $(this).val();
    var url = $("#postarasehir").data("url") + '?value=' + v;
    $.getJSON(url, function (data) {
        $("#postarailce").empty();
        $("#postarailce").removeAttr("disabled");
        $("#postarailce").append('<option selected disabled value="">--- Başlangıç İlçe Seçiniz---</option>');
        $.each(data, function (i, item) {
            $("#postarailce").append($("<option>").text(item.ilceAdi).val(item.ilceId));
        });
    });
});
$("#postsehir").change(function () {
    $("#postilce").empty();
    var v = $(this).val();
    var url = $("#postsehir").data("url") + '?value=' + v;
    $.getJSON(url, function (data) {
        $("#postilce").empty();
        $("#postilce").removeAttr("disabled");
        $("#postilce").append('<option selected disabled value="">--- Başlangıç İlçe Seçiniz---</option>');
        $.each(data, function (i, item) {
            $("#postilce").append($("<option>").text(item.ilceAdi).val(item.ilceId));
        });
    });
});
$("#postilce").change(function () {
    $("#postsemt").empty();
    var val = $(this).val();
    var url = $("#postilce").data("url") + '?value=' + val;
    $.getJSON(url, function (data) {
        ;
        $("#postsemt").empty();
        $("#postsemt").removeAttr("disabled");
        $("#postsemt").append('<option selected disabled value="">--- Başlangıç Nokta Seçiniz ---</option>');
        $.each(data, function (i, item) {
            $("#postsemt").append($("<option>").text(item.mahalleAdi).val(item.semtMahId));
        });
        $("#postsemt").removeAttr("disabled");
    });
});
$("#postendsehir").change(function () {
    $("#postendilce").empty();
    var v = $(this).val();
    var url = $("#postendsehir").data("url") + '?value=' + v;
    $.getJSON(url, function (data) {
        $("#postendilce").empty();
        $("#postendilce").removeAttr("disabled");
        $("#postendilce").append('<option selected disabled value="">--- Varış İlçe Seçiniz ---</option>');
        $.each(data, function (i, item) {
            $("#postendilce").append($("<option>").text(item.ilceAdi).val(item.ilceId));
        });
    });
});
$("#postendilce").change(function () {
    $("#postendsemt").empty();
    var val = $(this).val();
    var url = $("#postendilce").data("url") + '?value=' + val;
    $.getJSON(url, function (data) {
        $("#postendsemt").empty();
        $("#postendsemt").removeAttr("disabled");
        $("#postendsemt").append('<option selected disabled value="">--- Varış Nokta Seçiniz ---</option>');
        $.each(data, function (i, item) {
            $("#postendsemt").append($("<option>").text(item.mahalleAdi).val(item.semtMahId));
        });
    });
});
$("#postendsemt").change(function () {
    debugger;
    var valueStart = $("#postsemt").val();
    var valueEnd = $(this).val();
    var url = location.origin + '/Rezervation/GetLocationPrice?valueStart=' + valueStart + '&valueEnd=' + valueEnd;
    $.getJSON(url, function (data) {
        if (data.length == 0) {
            $("#postPrices").val('');
        }
        else {
            $.each(data, function (i, item) {
                console.log(item);
                $("#postPrices").val(item.totalPrice);
                $("input#postArrivalRoute").val(item.startSemtMahId);
                $("input#postDepartureRoute").val(item.endtSemtMahId);
            });
        }
    });
});
$("#postsemt").change(function () {
    var valueEnd = $("#postendsemt").val();
    var valueStart = $(this).val();
    var url = location.origin + '/Rezervation/GetLocationPrice?valueStart=' + valueStart + '&valueEnd=' + valueEnd;
    $.getJSON(url, function (data) {
        if (data.length == 0) {
            $("#postPrices").val('');
        }
        else {
            $.each(data, function (i, item) {
                debugger;
                console.log(item);
                $("#postPrices").val(item.totalPrice);
                $("input#postArrivalRoute").val(valueStart);
                $("input#DepartureRoute").val(valueEnd);
            });
        }
    });
});
/////////////////////////////////////
$("#postendilce").change(function () {
    debugger;
    var valueStart = $("#postilce").val();
    var valueEnd = $(this).val();
    var url = location.origin + '/Rezervation/GetLocationCityPrice?valueStart=' + valueStart + '&valueEnd=' + valueEnd;
    $.getJSON(url, function (data) {
        if (data.length == 0) {
            $("#postPrices").val('');
            $("#postPricesKdvsiz").val('');
        }
        else {
            $.each(data, function (i, item) {
                console.log(item);
                $("#postPrices").val(item.totalPrice);
                var kdvsiz = item.totalPrice / 1.18;
                $("#postPricesKdvsiz").val(kdvsiz.toString().split(".")[0] + "." + kdvsiz.toString().split(".")[1].substring(0, 2));
                $("input#postArrivalRoute").val(item.startSemtMahId);
                $("input#postDepartureRoute").val(item.endtSemtMahId);
            });
        }
    });
});
$("#postilce").change(function () {
    debugger;
    var valueEnd = $("#postendilce").val();
    var valueStart = $(this).val();
    var url = location.origin + '/Rezervation/GetLocationCityPrice?valueStart=' + valueStart + '&valueEnd=' + valueEnd;
    $.getJSON(url, function (data) {
        if (data.length == 0) {
            $("#postPrices").val('');
            $("#postPricesKdvsiz").val('');
        }
        else {
            $.each(data, function (i, item) {
                debugger;
                console.log(item);
                $("#postPrices").val(item.totalPrice);
                var kdvsiz = item.totalPrice / 1.18;
                $("#postPricesKdvsiz").val(kdvsiz.toString().split(".")[0] + "." + kdvsiz.toString().split(".")[1].substring(0, 2));
                $("input#postArrivalRoute").val(valueStart);
                $("input#DepartureRoute").val(valueEnd);
            });
        }
    });
});
/////////////////////////////////////
$("#postCarrier").change(function () {
    var val = $(this).val();
    if (val != "") {
        var phone = $("#postCarrierGetGsm").find('option[value=' + val + ']').text()
        $("#postUsergsm").val(phone);
    }
});

//$(document).ready(function () {
//    $("#postDate").flatpickr({
//        dateFormat: "d, m, Y",
//        noCalendar: false,
//        enableTime: false,
//    });

//    $("#postEndDate").flatpickr({
//        dateFormat: "d, m, Y",
//        noCalendar: false,
//        enableTime: false
//    });
//    $("#postTime").flatpickr({
//        dateFormat: "H:i",
//        noCalendar: true,
//        enableTime: true,
//    });

//    $("#postEndTime").flatpickr({
//        dateFormat: "H:i",
//        noCalendar: true,
//        enableTime: true
//    });
//});
$("body").on("keyup",
    "#postPersonCount",
    function () {
        console.log(this.value.length);
        if (this.value.length > 0) {
            $('.select2-results').show()
        }
        else {
            $('.select2-results').hide()
        }
    });
$("body").on("keyup",
    "#postPersonCount",
    function () {
        $("tr#addcustomer").remove()
        for (let i = 0; i < this.value - 1; i++) {
            var datehtml = `
            <tr id="addcustomer">
                <td>
                    <div>
                        <input type="radio" id="postCustomerTc`+ i + `" name="uyruk" />
                        <label for="uyruk">TC</label>
                        <input type="radio" id="postCustomerBilinmeyen`+ i + `" name="uyruk" />
                        <label for="uyruk">Bilinmeyen</label>
                        <input type="radio" id="postCustomerUyrukGir`+ i + `" name="uyruk" />
                        <label for="uyruk">Uyruk Gir</label>
                        <input type="text" id="postCustomerUyruk`+ i + `" name="uyruk" style="display:none" />
                    </div>
                </td>
                <td>
                    <div>
                        <input type="radio" id="postCustomerCinsiyet`+ i + `" value="Erkek" name="cinsiyet` + i + `" />
                        <label for="cinsiyet">Erkek</label>

                        <input type="radio" id="postCustomerCinsiyet`+ i + `" value="Kadın" name="cinsiyet` + i + `" />
                        <label for="cinsiyet">Kadın</label>
                    </div>
                </td>
                <td>
                    <input class="form-control" type="text" placeholder="Ad"
                        id="postCustomerAd`+ i + `" />
                </td>
                <td>
                    <input class="form-control" type="text" placeholder="Soyad"
                        id="postCustomerSoyad`+ i + `" />
                </td>
                <td>
                    <input class="form-control" type="text" placeholder="Email"
                        id="postCustomerEmail`+ i + `" />
                </td>
                <td id="postCustomerPasaportNo`+ i + `" style="display:none">
                    <input class="form-control" type="text" placeholder="Pasaport No"
                        id="postCustomerPasaportNo`+ i + `" style="display:none" />
                </td>
                <td id="postCustomerKimlik`+ i + `" style="display:none">
                    <input class="form-control" type="text" placeholder="Kimlik No"
                        id="postCustomerKimlik`+ i + `" style="display:none" />
                </td>
                <td>
                    <input class="form-control" type="text" placeholder="Telefon"
                        id="postCustomerTelefon`+ i + `" />
                </td>
            </tr>
            `;
            $("tbody#customer").children().first().after(datehtml)
        }
    });
$('a#postcustomer').on('click', function () {
    debugger;
    $("tbody#customer").children().each(function (index) {
        var postCustomerUyruk = $(this).find('input#postCustomerUyruk').val();
        var postCustomerCinsiyet = $(this).find("input#postCustomerCinsiyet:checked").val();
        var postCustomerAd = $(this).find("input#postCustomerAd").val();
        var postCustomerSoyad = $(this).find("input#postCustomerSoyad").val();
        var postCustomerEmail = $(this).find("input#postCustomerEmail").val();
        var postCustomerKimlik = $(this).find("input#postCustomerKimlik").val();
        var postCustomerPasaportNo = $(this).find("input#postCustomerPasaportNo").val();
        var postCustomerTelefon = $(this).find("input#postCustomerTelefon").val();
        var postCustomerSms = $(this).find("input#postCustomerSms").val();
        $('textarea#postCustomer').append(postCustomerAd + " " + postCustomerSoyad + ", ");
        $("#kapanmodal").click();
    });
})

$('a#postreferans').on('click', function () {
    var postReferenceNameSurname = $('#postReferenceNameSurname').val();
    var postReferenceEmail = $("#postReferenceEmail").val();
    var postReferencePhone = $("#postReferencePhone").val();
    $.post(location.origin + "/Rezervation/ReferenceAdd", {
        NameSurname: postReferenceNameSurname,
        Email: postReferenceEmail,
        Phone: postReferencePhone
    }, function (data) {
        console.log(data);
        $('select#postReference').append('<option selected value="' + data.id + '">' + data.nameSurname + '</option>');
    });
})

$('a#postaddCustomerhtml').on('click', function () {
    var datehtml = `
            <tr id="addcustomer">
                <td>
                    <div>
                        <input type="radio" id="postCustomerTc`+ $(" tbody #customer").children().length + `" name="uyruk" />
                        <label for="uyruk">TC</label>
                        <input type="radio" id="postCustomerBilinmeyen`+ $(" tbody #customer").children().length + `" name="uyruk" />
                        <label for="uyruk">Bilinmeyen</label>
                        <input type="radio" id="postCustomerUyrukGir`+ $(" tbody #customer").children().length + `" name="uyruk" />
                        <label for="uyruk">Uyruk Gir</label>
                        <input type="text" id="postCustomerUyruk`+ $(" tbody #customer").children().length + `" name="uyruk" style="display:none" />
                    </div>
                </td>
                <td>
                    <div>
                        <input type="radio" id="postCustomerCinsiyet`+ $(" tbody #customer").children().length + `" value="Erkek" name="cinsiyet` + $(" tbody #customer").children().length + `" />
                        <label for="cinsiyet">Erkek</label>

                        <input type="radio" id="postCustomerCinsiyet`+ $(" tbody #customer").children().length + `" value="Kadın" name="cinsiyet` + $(" tbody #customer").children().length + `" />
                        <label for="uyruk">Kadın</label>
                    </div>
                </td>
                <td>
                    <input class="form-control" type="text"
                        id="postCustomerAd`+ $(" tbody #customer").children().length + `" placeholder="Ad"/>
                </td>
                <td>
                    <input class="form-control" type="text"
                        id="postCustomerSoyad`+ $(" tbody #customer").children().length + `" placeholder="Soyad"/>
                </td>
                <td>
                    <input class="form-control" type="text"
                        id="postCustomerEmail`+ $(" tbody #customer").children().length + `" placeholder="Email"/>
                </td>
                <td id="postCustomerPasaportNo`+ $(" tbody #customer").children().length + `" style="display:none">
                <input class="form-control" type="text"
                    id="postCustomerPasaportNo`+ $(" tbody #customer").children().length + `" style="display:none" placeholder="Pasaport No"/>
            </td>
            <td id="postCustomerKimlik`+ $(" tbody #customer").children().length + `" style="display:none">
            <input class="form-control" type="text"
                id="postCustomerKimlik`+ $(" tbody #customer").children().length + `" style="display:none" placeholder="Kimlik No"/>
        </td>
        <td>
            <input class="form-control" type="text"
                id="postCustomerTelefon`+ $(" tbody #customer").children().length + `" placeholder="Telefon"/>
        </td>
    </tr>
    `;
    $("tbody#customer").children().first().after(datehtml)
    $("#postPersonCount").val($("tbody#customer").children().length)
});

$("body").on("click",
    "[id*='postCustomerUyrukGir']",
    function () {
        var id = $(this).attr('id');
        console.log(id.substr(id.length - 1));
        if (id.substr(id.length - 1) == 'r') {
            $('#postCustomerUyruk').show();
            $('#postCustomerUyruk').val("");
            $('th#postCustomerPasaportNo').each(function (index) { $('th#postCustomerPasaportNo').show() })
            $('input#postCustomerPasaportNo').each(function (index) { $('input#postCustomerPasaportNo').show() })
            $('td#postCustomerPasaportNo').each(function (index) { $('td#postCustomerPasaportNo').show() })
            $('input#postCustomerKimlik').each(function (index) { $('input#postCustomerKimlik').hide() })
            $('th#postCustomerKimlik').each(function (index) { $('th#postCustomerKimlik').hide() })
            $("td#postCustomerKimlik").each(function (index) { $("td#postCustomerKimlik").hide() })
        }
        else {
            $('#postCustomerUyruk' + id.substr(id.length - 1)).show();
            $('#postCustomerUyruk' + id.substr(id.length - 1)).val("");
            $('th#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('th#postCustomerPasaportNo' + id.substr(id.length - 1)).show() })
            $('input#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('input#postCustomerPasaportNo' + id.substr(id.length - 1)).show() })
            $('td#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('td#postCustomerPasaportNo' + id.substr(id.length - 1)).show() })
            $('input#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('input#postCustomerKimlik' + id.substr(id.length - 1)).hide() })
            $('th#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('th#postCustomerKimlik' + id.substr(id.length - 1)).hide() })
            $("td#postCustomerKimlik" + id.substr(id.length - 1)).each(function (index) { $("td#postCustomerKimlik" + id.substr(id.length - 1)).hide() })
        }
    });

$("body").on("click",
    "[id*='postCustomerBilinmeyen']",
    function () {
        var id = $(this).attr('id');
        debugger;
        console.log(id.substr(id.length - 1));
        if (id.substr(id.length - 1) == 'n') {
            $('#postCustomerUyruk').hide();
            $('#postCustomerUyruk').val("Bilinmiyor");
            $('th#postCustomerKimlik').each(function (index) { $('th#postCustomerKimlik').hide() })
            $('td#postCustomerKimlik').each(function (index) { $('td#postCustomerKimlik').hide() })
            $('input#postCustomerKimlik').each(function (index) { $('input#postCustomerKimlik').hide() })
            $('th#postCustomerPasaportNo').each(function (index) { $('th#postCustomerPasaportNo').hide() })
            $('td#postCustomerPasaportNo').each(function (index) { $('td#postCustomerPasaportNo').hide() })
            $('input#postCustomerPasaportNo').each(function (index) { $('input#postCustomerPasaportNo').hide() })
        }
        else {
            $('#postCustomerUyruk' + id.substr(id.length - 1)).hide()
            $('#postCustomerUyruk' + id.substr(id.length - 1)).val("Bilinmiyor")
            $('th#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('th#postCustomerKimlik' + id.substr(id.length - 1)).hide() })
            $('td#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('td#postCustomerKimlik' + id.substr(id.length - 1)).hide() })
            $('input#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('input#postCustomerKimlik' + id.substr(id.length - 1)).hide() })
            $('th#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('th#postCustomerPasaportNo' + id.substr(id.length - 1)).hide() })
            $('td#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('td#postCustomerPasaportNo' + id.substr(id.length - 1)).hide() })
            $('input#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('input#postCustomerPasaportNo' + id.substr(id.length - 1)).hide() })
        }
    });

$("body").on("click",
    "[id*='postCustomerTc']",
    function () {
        var id = $(this).attr('id')
        if (id.substr(id.length - 1) == 'c') {
            $('#postCustomerUyruk').hide();
            $('#postCustomerUyruk').val("TC");
            $('th#postCustomerPasaportNo').each(function (index) { $('th#postCustomerPasaportNo').hide() })
            $('td#postCustomerPasaportNo').each(function (index) { $('td#postCustomerPasaportNo').hide() })
            $('input#postCustomerPasaportNo').each(function (index) { $('input#postCustomerPasaportNo').hide() })
            $('th#postCustomerKimlik').each(function (index) { $('th#postCustomerKimlik').show() })
            $('td#postCustomerKimlik').each(function (index) { $('td#postCustomerKimlik').show() })
            $('input#postCustomerKimlik').each(function (index) { $('input#postCustomerKimlik').show() })
        }
        else {
            $('#postCustomerUyruk' + id.substr(id.length - 1)).hide();
            $('#postCustomerUyruk' + id.substr(id.length - 1)).val("TC");
            $('th#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('th#postCustomerPasaportNo' + id.substr(id.length - 1)).hide() })
            $('td#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('td#postCustomerPasaportNo' + id.substr(id.length - 1)).hide() })
            $('input#postCustomerPasaportNo' + id.substr(id.length - 1)).each(function (index) { $('input#postCustomerPasaportNo' + id.substr(id.length - 1)).hide() })
            $('th#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('th#postCustomerKimlik' + id.substr(id.length - 1)).show() })
            $('td#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('td#postCustomerKimlik' + id.substr(id.length - 1)).show() })
            $('input#postCustomerKimlik' + id.substr(id.length - 1)).each(function (index) { $('input#postCustomerKimlik' + id.substr(id.length - 1)).show() })
        }
    });
$('#postPlate').change(function () {
    var url = location.origin + '/Rezervation/GetVehiclePrices?value=' + $(this).data("bind");
    $.getJSON(url, function (data) {
        $("#postVehiclePrices").val("");
        $.each(data, function (i, item) {
            console.log(item);
            $("#postVehiclePrices").val();
            var data = item.vehiclePrice + $('input#postVehiclePrices').val();
            var arttir = 0;
            var azalt = 0;
            arttir += Number(item.vehiclePrice) + Number($('input#postVehiclePrices').val());
            azalt -= Number(item.vehiclePrice) - Number($('input#postVehiclePrices').val());
            var c = $('#postPlate').find(":selected").val() == item.id ? $('input#postVehiclePrices').val(arttir) : $('input#postVehiclePrices').val(azalt);
        });
    });
});

$('input#postaradurak').change(function () {
    if (!$(this).is(":checked")) {
        $('#postarasehir').hide();
        $('#postarailce').hide();
    }
    var data = $(this).data("bind") + $('input#postPrices').val();
    var arttir = 0;
    var azalt = 0;
    arttir += Number($(this).data("bind")) + Number($('input#postPrices').val());
    azalt -= Number($(this).data("bind")) - Number($('input#postPrices').val());
    var c = this.checked ? $('input#postPrices').val(arttir) : $('input#postPrices').val(azalt);
});
$('input#AdditionalService').change(function () {
    var data = $(this).data("bind") + $('input#postPrices').val();
    var arttir = 0;
    var azalt = 0;
    arttir += Number($(this).data("bind")) + Number($('input#postPrices').val());
    azalt -= Number($(this).data("bind")) - Number($('input#postPrices').val());
    var c = this.checked ? $('input#postPrices').val(arttir) : $('input#postPrices').val(azalt);
});