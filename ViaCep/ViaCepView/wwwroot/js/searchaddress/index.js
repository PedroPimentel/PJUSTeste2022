var baseAddressApi;

function verify() {

    let cep = $("#numCep").val();

    if (cep.length != 8) {
        $("#errorCep").html("Favor inserir um CEP com 8 dígitos");
        $("#errorCep").show();
    }
    else {

        $("#errorCep").hide();

        $.ajax({
            method: "GET",
            url: baseAddressApi + "api/v1/SearchAddress/GetAddress/" + cep,
        })
            .done(function (response) {

                $("#cardError").hide();
                $("#cardSuccess").show();

                if (response.erro == null || response.erro == "" || response.erro == undefined) {

                    $("#district").html("CEP: " + response.cep)
                    $("#cep").html("Logradouro: " + response.logradouro)
                    $("#complement").html("Complemento: " + response.complemento)
                    $("#ddd").html("Bairro: " + response.bairro)
                    $("#gia").html("Localidade: " + response.localidade)
                    $("#ibge").html("UF: " + response.uf)
                    $("#locality").html("IBGE: " + response.ibge)
                    $("#publicPlace").html("GIA: " + response.gia)
                    $("#siaf").html("DDD: " + response.ddd)
                    $("#uf").html("SIAFI: " + response.siafi)

                    showAlertToastr("Consulta salva com sucesso", "success")
                }

                if (response.erro) {
                    $("#cardSuccess").hide();
                    $("#cardError").show();
                    $("#responseError").html("CEP inválido =|");
                }
            })
            .fail(function (jqXHR, textStatus, response) {

                $("#cardSuccess").hide();
                $("#cardError").show();
                $("#responseError").html("Falha na requisição");
            });
    }
}

function showAlertToastr(message, status) {

    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": false,
        "positionClass": "toast-bottom-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "5000",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    if (status == "success") {
        toastr.success(message);
    }
    else {
        toastr.error(message);
    }
}