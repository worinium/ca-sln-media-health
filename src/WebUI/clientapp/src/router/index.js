import Vue from "vue";
import VueRouter from "vue-router";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: () => import("../views/PreliminaryPages/Home.vue")
  },
  {
    path: "/about",
    name: "About",
    component: () => import("../views/PreliminaryPages/About.vue")
  },

  {
    path: "/contact",
    name: "ContactUs",
    component: () => import("../views/PreliminaryPages/ContactUs.vue")
  },
  {
    path: "/amrservices",
    name: "AudienceMeasurementReport",
    component: () => import("../views/Services/AMRServices.vue")
  },
  {
    path: "/mmrservices",
    name: "MediaMonitoringReport",
    component: () => import("../views/Services/MMRServices.vue")
  },
  {
    path: "/mmrservices",
    name: "Integration Analysis",
    component: () => import("../views/Services/MMRServices.vue")
  },
  {
    path: "/login",
    name: "Login",
    component: () => import("../views/Authentication/Login.vue")
  },
  {
    path: "/signup",
    name: "SignUp",
    component: () => import("../views/Authentication/SignUp.vue")
  }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
