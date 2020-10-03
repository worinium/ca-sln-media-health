<template>
<v-row>
    <v-carousel cycle height="550" hide-delimiter-background show-arrows-on-hover>
        <v-carousel-item v-for="(slide, i) in slides" :key="i">
            <v-sheet :color="colors[i]" height="100%">
                <v-row class="fill-height" align="center" justify="center">
                    <div class="display-3">{{ slide }} Slide</div>
                </v-row>
            </v-sheet>
        </v-carousel-item>
    </v-carousel>
</v-row>
</template>

<script>
export default {
    data() {
        return {
            colors: ["black", "green"],
            slides: ["First", "Second"],
            show: false
        };
    }
};
</script>

<style lang="sass" scoped></style>
