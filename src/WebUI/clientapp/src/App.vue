<template>
<v-app id="app">

    <app-header />
    <router-view></router-view>
    <app-footer />

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
        CheckLoginExist: true
    }),
    methods() {

    }
};
</script>
