<template>
<v-container class="fill-height" fluid>
    <v-row align="center" justify="center">
        <v-col cols="12" md="8" sm="6">
            <v-card class="elevation-12">
                <v-toolbar raise elevation tile>
                    <v-toolbar-title>Login form</v-toolbar-title>

                </v-toolbar>
                <v-card-text>
                    <v-form>
                        <v-text-field label="Login" name="login" prepend-icon="mdi-account" type="text"></v-text-field>

                        <v-text-field id="password" label="Password" name="password" prepend-icon="mdi-lock" type="password"></v-text-field>
                    </v-form>
                </v-card-text>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn>Login</v-btn>
                </v-card-actions>
            </v-card>
        </v-col>
    </v-row>
</v-container>
</template>

<script>
export default {
    data() {
        return {
            userId: ''
        }
    },
    computed: {
        validation() {
            return this.userId.length > 4 && this.userId.length < 13
        }
    }
}
</script>

<style scoped>

</style>
