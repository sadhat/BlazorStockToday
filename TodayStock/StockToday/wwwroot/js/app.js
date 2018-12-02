
function launch_toast(message) {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": false,
        "positionClass": "toast-top-full-width",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "3000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    toastr["error"](message);
    return true;
}

function autocomplete() {
    var options = {
        url: "https://api.iextrading.com/1.0/ref-data/symbols",
        getValue: "name",
        template: {
            type: "description",
            fields: {
                description: "symbol"
            }
        },
        list: {
            match: {
                enabled: true
            },
            maxNumberOfElements: 6,
            onSelectItemEvent: function() {
                var value = $("#stock_symbol").getSelectedItemData().symbol;
                $("#stock_symbol").val(value).trigger("change");
            },
            onKeyEnterEvent: function() {
                var value = $("#stock_symbol").getSelectedItemData().symbol;
                $("#stock_symbol").val(value).trigger("change");
            }
}
    };
    
    $(function () {
        $("#stock_symbol").easyAutocomplete(options);
    });
}

function clearSymbolInput() {
    $("#stock_symbol").val('');
    return true;
}

function registerSymbol(symbols) {
    var dict = {};
    var socket = io('https://ws-api.iextrading.com/1.0/tops');
    var msg;
    // Listen to the channel's messages
    socket.on('message', message => msg = message);
    setInterval(() => {
        var msgObj = JSON.parse(msg);
        if (dict[msgObj.symbol] !== msg)
        {
            DotNet.invokeMethod('StockToday', 'OnMessageReceived', msg);
            console.time("messageReceived");
            dict[msgObj.symbol] = msg;
            console.timeEnd("messageReceived");
        }
    }, 5000);
    // Connect to the channel
    socket.on('connect',
        () => {
            socket.emit('subscribe', symbols);
        });
    socket.on('disconnect', () => console.log('Disconnected.'));
}

$(function () {
    $('[data-toggle="tooltip"]').tooltip();
});