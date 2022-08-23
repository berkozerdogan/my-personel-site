import { createRouter, createWebHistory } from "vue-router";
// import HomePage from "../views/HomePage.vue";
import Contact from "../views/Contact.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  linkActiveClass: "active",
  routes: [
    {
      path: "/",
      name: "home",
      // component: HomePage,
      component: () => import("../views/MainPage.vue"),
    },
    {
      path: "/about",
      name: "about",
      component: () => import("../views/Information.vue"),
    },
    {
      path: "/projects",
      name: "projects",
      component: () => import("../views/Projects.vue"),
    },
    {
      path: "/contact",
      name: "contact",
      component: Contact,
    },
    {
      path: "/comments",
      name: "comments",
      component: () => import("../views/Comments.vue"),
    },
    {
      path: "/listenToMe",
      name: "listenToMe",
      component: () => import("../views/listenToMe.vue"),
    },
    {
      path: "/userLogin",
      name: "userLogin",
      component: () => import("../views/Login.vue"),
    },
  ],
});

export default router;
