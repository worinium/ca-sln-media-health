<template>
  <v-app>
      <navbar/>
      <v-main>
        <router-view/>
      </v-main>
      <footers/>
  </v-app>
</template>

<script>
import footers from './components/footers';
import navbar from './components/navbar';

export default {
  name: 'App',

  components: {
    navbar,  footers
  },

  data: () => ({
    //
  }),
};
</script>
