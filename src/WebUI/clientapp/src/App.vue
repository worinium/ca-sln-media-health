<template>
<v-app id="app">
    <v-row v-if="CheckLoginExist">
        <app-admin />
    </v-row>
    <v-row v-else>
        <app-default />
    </v-row>
</template>

<script>
import adminLayout from './components/Layout/adminLayout';
import defaultLayout from './components/Layout/defaultLayout';

export default {
    name: 'App',

    components: {
        'app-default': defaultLayout,
        'app-admin': adminLayout
    },

    data: () => ({
        CheckLoginExist: false
    }),
    methods() {

    }
};
</script>
