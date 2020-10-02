<template>
<v-app id="app">
    <v-row v-if="CheckLoginExist">
        <app-header />
        <router-view></router-view>
        <app-footer />
    </v-row>
    <v-row v-else>
        <app-header />
        <v-main>
            <v-row>
                <v-col cols="3"></v-col>
                <v-col cols="6">
                    <router-view></router-view>
                </v-col>
                <v-col cols="3"></v-col>
            </v-row>
            <app-footer />
        </v-main>
    </v-row>
</v-app>
</template>

<script>
import Navbar from "./components/navbar.vue";
import Footer from "./components/footers.vue";

export default {
    name: 'App',

    components: {
        "app-header": Navbar,
        "app-footer": Footer
    },

    data: () => ({
        CheckLoginExist: false
    }),
    methods() {

    }
};
</script>
