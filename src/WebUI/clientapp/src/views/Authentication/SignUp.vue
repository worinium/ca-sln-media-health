<template>
<v-container class="ma-2">
    <v-row align="center" justify="center">
        <v-col cols="12" md="8" sm="4">
            <v-card class="elevation-12">
                <v-toolbar raise elevation tile>
                    <v-toolbar-title>Sign-Up Form</v-toolbar-title>

                </v-toolbar>
                <v-card-text>
                    <v-form ref="form" v-model="valid" lazy-validation>
                        <v-text-field v-model="name" :counter="10" :rules="nameRules" label="Name" required> </v-text-field>

                        <v-text-field v-model="email" :rules="emailRules" label="E-mail" required></v-text-field>

                        <v-select v-model="select" :items="items" :rules="[v => !!v || 'Item is required']" label="Gender" required></v-select>

                        <v-checkbox v-model="checkbox" :rules="[v => !!v || 'You must agree to continue!']" label="Do you agree?" required></v-checkbox>

                        <v-row>
                            <v-spacer></v-spacer>
                            <v-btn dark class="mr-4" @click="reset">
                                Register
                            </v-btn>

                            <v-btn dark @click="resetValidation">
                                Clear
                            </v-btn>

                            <v-spacer></v-spacer>
                        </v-row>
                    </v-form>
                </v-card-text>
            </v-card>
        </v-col>
    </v-row>

</v-container>
</template>

<script>
import {
    validationMixin
} from 'vuelidate'
import {
    required,
    maxLength,
    email
} from 'vuelidate/lib/validators'

export default {
    mixins: [validationMixin],

    validations: {
        name: {
            required,
            maxLength: maxLength(10)
        },
        email: {
            required,
            email
        },
        select: {
            required
        },
        checkbox: {
            checked(val) {
                return val
            },
        },
    },

    data: () => ({
        name: '',
        email: '',
        select: null,
        items: [
            'Male',
            'Female',
        ],
        checkbox: false,
    }),

    computed: {
        checkboxErrors() {
            const errors = []
            if (!this.$v.checkbox.$dirty) !this.$v.checkbox.checked && errors.push('You must agree to continue!')
            return errors
        },
        selectErrors() {
            const errors = []
            if (!this.$v.select.$dirty) !this.$v.select.required && errors.push('Item is required')
            return errors
        },
        nameErrors() {
            const errors = []
            if (!this.$v.name.$dirty) !this.$v.name.maxLength && errors.push('Name must be at most 10 characters long') && !this.$v.name.required && errors.push('Name is required.')
            return errors
        },
        emailErrors() {
            const errors = []
            if (!this.$v.email.$dirty) !this.$v.email.email && errors.push('Must be valid e-mail') && !this.$v.email.required && errors.push('E-mail is required')
            return errors
        },
    },

    methods: {
        submit() {
            this.$v.$touch()
        },
        clear() {
            this.$v.$reset()
            this.name = ''
            this.email = ''
            this.select = null
            this.checkbox = false
        },
    },
}
</script>
