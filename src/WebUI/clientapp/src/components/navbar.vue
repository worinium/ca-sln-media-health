<template>
    <v-toolbar  flat tile rounded>
       <v-app-bar-nav-icon></v-app-bar-nav-icon>
          <v-toolbar-title to="/">Media Health</v-toolbar-title>
          <v-spacer></v-spacer>
            <v-toolbar-items>
              <v-btn flat to="/">Home</v-btn>
              <v-btn to="/mmrservices" flat><span>Services</span> <span><v-icon>mdi-heart</v-icon></span></v-btn>
              <v-btn to="/about" flat>About Us</v-btn>
              <v-btn to="/contact" flat>Contact Us</v-btn>
            </v-toolbar-items>
          <v-spacer></v-spacer>
          <v-toolbar-items class="hidden-sm-and-down">
                  <v-btn to="/signup" flat>Sign Up </v-btn>
                  <v-btn to="/login" flat>login</v-btn>
          </v-toolbar-items>
          <v-btn icon>
            <v-icon>mdi-heart</v-icon>
          </v-btn>
          <v-btn icon>
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn>
      </v-toolbar>
</template>
<script>
export default {
  data: () => ({
      notifications: [
        { id: 1, title: 'Click Me' },
        { id: 2, title: 'Click Me' },
        { id: 3, title: 'Click Me' },
        { id: 4, title: 'Click Me 2' }
      ]
    })
}
</script>
