<template>
<div id="app">
    <app-header />
    <v-main>
        <v-row>
            <v-col>
            </v-col>
            <v-col>
                <slot />
            </v-col>
        </v-row>
        <app-footer />
    </v-main>
</div>
</template>

<script>
import Navbar from "./components/navbar.vue";
import Footer from "./components/footer.vue";
export default {
    name: "app",
    components: {
        'app-header': Navbar,
        'app-footer': Footer
    }
};
</script>

<style lang="scss">
#app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
}

#nav {
    padding: 30px;

    a {
        font-weight: bold;
        color: #2c3e50;

        &.router-link-exact-active {
            color: #42b983;
        }
    }
}
</style>
