
var app = app || {};
app.Views = app.Views || {};

(function () {
    'use strict';

    var page, viewModel, vmFunctions;

    function VM() {
        var vm = this;

        vm.availablePages = ko.observableArray(_.map([
            {
                Title: 'OSRS tracker',
                Description: 'Old school runescape xp tracker bot',
                Link: '/OSRSTracker'
            }
        ]), vmFunctions.mappers.mapPage);

        return vm;
    }

    vmFunctions = {
        computed: {
        },

        events: {
            page_load: function () {
                var page = this, baseUrl = '';
                debugger;
            }
        },

        mappers: {
            mapPage: function (page) {

                page.load = _.bind(vmFunctions.events.page_load, page);

                return page;
            }
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