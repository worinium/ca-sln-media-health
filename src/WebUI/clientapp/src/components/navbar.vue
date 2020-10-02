<template>
<v-row>
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
    </v-card>
    <v-toolbar rounded tile>
        <v-app-bar-nav-icon @click="drawer=true"> </v-app-bar-nav-icon>
        <v-app-bar-title>
            <route-link to="/" tag style="cursor:pointer">MediaHealth</route-link>
        </v-app-bar-title>
        <v-spacer></v-spacer>
        <v-toolbar-items>
            <v-btn flat to="/">
                <span>Home</span>
            </v-btn>
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
        </v-toolbar-items>
        <v-menu open-on-hover transition="slide-x-transition" bottom right offset-y>
            <template v-slot:activator="{ on, attrs }">
                <v-btn icon v-bind="attrs" v-on="on">
                    <v-icon>mdi-dots-vertical</v-icon>
                </v-btn>
            </template>
            <v-card class="mx-auto" max-width="300" tile>
                <v-list dense>
                    <v-subheader>THEMES</v-subheader>
                    <v-list-item-group v-model="theme" color="primary">
                        <v-list-item v-for="(item, i) in themes" :key="i" link>
                            <v-list-item-action>
                                <v-icon v-text="item.icon"></v-icon>
                            </v-list-item-action>
                            <v-list-item-action>
                                <v-list-item-title v-text="item.text"></v-list-item-title>
                            </v-list-item-action>
                        </v-list-item>
                    </v-list-item-group>
                </v-list>
            </v-card>
        </v-menu>
    </v-toolbar>
</v-row>
</template>

<script>
export default {
    data: () => ({
        activate: true,
        theme: 1,
        themes: [{
                text: "Dark",
                icon: "mdi-clock"
            },
            {
                text: "Light",
                icon: "mdi-account"
            }
        ],
        drawer: true,
        navigationDrawerItems: [{
                index: 1,
                title: "Dashboard",
                icon: "mdi-home-city"
            },
            {
                index: 2,
                title: "My Account",
                icon: "mdi-account",
                link: "/amservices"
            },
            {
                index: 3,
                title: "Media Monitoring",
                icon: "mdi-home-city",
                link: "/amservices"
            },
            {
                index: 4,
                title: "Audience Measurement",
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
    })
};
</script>
