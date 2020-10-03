<template>
<v-app id="app">
    <app-header />

    <v-row class="grey lighten-5">
        <v-row no-gutters>
            <v-col cols="3">
                <v-card class="pa-2" outlined tile>
                    <app-aside />
                </v-card>
            </v-col>
            <v-col cols="9">
                <v-card class="pa-2" outlined tile>
                    <router-view></router-view>
                </v-card>
            </v-col>
        </v-row>
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
