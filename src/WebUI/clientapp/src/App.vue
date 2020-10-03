<template>
<v-app id="app">
    <app-header />

    <v-row no-gutters class="grey lighten-5">
        <v-col cols="2">
            <app-aside />
        </v-col>
        <v-col cols="10">
            <router-view></router-view>
        </v-col>
    </v-row>

    <app-footer />

</v-app>
</template>

<script>
import Navbar from "./components/navbar.vue";
import Footer from "./components/footers.vue";
import SideBar from "./components/aside.vue";

export default {
    name: 'App',

    components: {
        "app-header": Navbar,
        "app-footer": Footer,
        "app-aside": SideBar,
    },

    data: () => ({
        CheckLoginExist: true
    }),
    methods() {

    }
};
</script>
