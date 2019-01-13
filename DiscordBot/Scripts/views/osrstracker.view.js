
var app = app || {};
app.Views = app.Views || {};

(function () {
    'use strict';

    var page, viewModel, vmFunctions;

    function VM() {
        var vm = this;

        return vm;
    }

    vmFunctions = {
        computed: {
        },

        events: {
        },

        mappers: {
        },

        subscriptions: {

        }
    };

    page = {
        viewModel: null,

        events: {
        },

        getters: {
        },

        helpers: {
        },

        init: function () {
            var feedback;

            // Applying the viewmodel to the page
            ko.applyBindings(viewModel);
        }
    };

    viewModel = new VM();
    page.viewModel = viewModel;

    app.Views.Home = page;

    $(document).ready(page.init);

})();