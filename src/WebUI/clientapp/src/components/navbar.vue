<template>
<v-card>
    <v-navigation-drawer v-model="drawer" absolute temporary app clipped>
        <v-list v-for="(item, index) in navigationDrawerItems" :key="index" dense>
            <v-list-item link>
                <v-list-item-action>
                    <v-icon>{{ item.icon }}</v-icon>
                </v-list-item-action>
                <v-list-item-content>
                    <v-list-item-title>{{ item.title }}</v-list-item-title>
                </v-list-item-content>
            </v-list-item>
        </v-list>
    </v-navigation-drawer>

    <v-toolbar>
        <v-toolbar-title class="hidden-sm-and-up">Media-Health</v-toolbar-title>
        <v-toolbar-items class=" hidden-sm-and-down">
            <v-btn flat to="/">
                <v-app-bar-title>
                    <route-link to="/" tag style="cursor:pointer">MediaHealth</route-link>
                </v-app-bar-title>
            </v-btn>
        </v-toolbar-items>
        <v-spacer></v-spacer>
        <v-toolbar-items class="hidden-sm-and-down">
            <v-menu v-for="([text, rounded]) in btns" :key="text" :rounded="rounded" open-on-hover offset-y transition="slide-x-transition" bottom right>
                <template v-slot:activator="{ on, attrs }">
                    <v-btn flat v-bind="attrs" v-on="on">
                        Services <v-icon>{{show ? "mdi-chevron-up" : "mdi-chevron-down"}}</v-icon>
                    </v-btn>
                </template>
                <v-list dense>
                    <v-list-item v-for="(item, index) in services" :key="index" @click="Manipulate" link>
                        <v-list-item-icon>
                            <v-icon v-text="item.icon"></v-icon>
                        </v-list-item-icon>
                        <v-list-item-action>
                            <v-list-item-title>{{ item.title }}</v-list-item-title>
                        </v-list-item-action>
                    </v-list-item>
                </v-list>
            </v-menu>

            <v-btn to="/about" flat>
                About Us
            </v-btn>
            <v-btn to="/contact" flat>
                Contact Us
            </v-btn>
        </v-toolbar-items>
        <v-spacer></v-spacer>
        <v-toolbar-items class="hidden-sm-and-down">
            <v-btn to="/signup" flat>Sign Up </v-btn>
            <v-btn to="/login" flat>login</v-btn>

            <v-btn flat>
                <v-menu transition="slide-x-transition" offset-y bottom right>
                    <template v-slot:activator="{ on, attrs }">
                        <v-btn icon v-bind="attrs" v-on="on">
                            <v-icon>mdi-dots-vertical</v-icon>
                        </v-btn>
                    </template>
                    <v-card class="mx-auto" max-width="300" tile>
                        <v-switch v-model="$vuetify.theme.dark" hint="Toggle themes" inset label=" Theming" persistent-hint>
                        </v-switch>
                    </v-card>
                </v-menu>
            </v-btn>
        </v-toolbar-items>
        <v-app-bar-nav-icon @click.native.stop="drawer=!drawer" class="hidden-sm-and-up"> </v-app-bar-nav-icon>

    </v-toolbar>
</v-card>
</template>

<script>
export default {
    data: () => ({
        activate: true,

        drawer: false,
        navigationDrawerItems: [{
                index: 1,
                title: "Home",
                icon: "mdi-home-city"
            },
            {
                index: 2,
                title: "Services",
                icon: "mdi-account",
                link: "/amservices"
            },
            {
                index: 3,
                title: "About",
                icon: "mdi-home-city",
                link: "/amservices"
            },
            {
                index: 4,
                title: "Contact Us",
                icon: "mdi-account-group-outline",
                link: "/amservices"
            },
            {
                index: 5,
                title: "Setting",
                icon: "mdi-cog"
            }
        ],
        mini: true,
        services: [{
                icon: "mdi-domain",
                title: "Media Monitoring",
                link: "/mmrservices"
            },
            {
                icon: "mdi-message-text",
                title: "Audience Measurement",
                link: "/amrservices"
            },
            {
                icon: "mdi-flag",
                title: "Integration Analysis",
                link: ""
            }
        ],
        btns: [
            //  ['Removed', '0'],
            // ['Large', 'lg'],
            ['Custom', 'b-xl'],
        ],
        colors: ['deep-purple accent-4', 'error', 'teal darken-1'],
        items: [...Array(4)].map((_, i) => `Item ${i}`),
    }),
};
</script>
