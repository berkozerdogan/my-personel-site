<script setup>
import { RouterLink, RouterView } from "vue-router";
</script>

<template>
  <div class="d-flex" id="wrapper">
    <!-- Sidebar-->
    <div class="border-end bg-white" id="sidebar-wrapper">
      <div class="sidebar-heading border-bottom bg-light">
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="/about"
          >Berk Özerdoğan</a
        >
      </div>
      <div class="list-group list-group-flush">
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="/projects"
          >Projelerim</a
        >
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="#!"
          >Shortcuts</a
        >
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="#!"
          >Overview</a
        >
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="#!"
          >Events</a
        >
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="#!"
          >Profile</a
        >
        <a
          class="list-group-item list-group-item-action list-group-item-light p-3"
          href="/listenToMe"
          >Dinlemek isterseniz</a
        >
      </div>
    </div>
    <!-- Page content wrapper-->
    <div id="page-content-wrapper">
      <!-- Top navigation-->
      <nav class="navbar navbar-expand-lg navbar-light bg-light border-bottom">
        <div class="container-fluid">
          <button class="btn btn" id="sidebarToggle">
            <i class="fa-solid fa-arrow-right-arrow-left"></i>
          </button>
          <button
            class="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav ms-auto mt-2 mt-lg-0">
              <li class="nav-item active">
                <a class="nav-link" href="/">Home</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="/contact">Contact</a>
              </li>
              <li class="nav-item dropdown">
                <a
                  class="nav-link dropdown-toggle"
                  id="navbarDropdown"
                  href="#"
                  role="button"
                  data-bs-toggle="dropdown"
                  aria-haspopup="true"
                  aria-expanded="false"
                  ><i class="fa-solid fa-user"></i
                ></a>
                <div
                  class="dropdown-menu dropdown-menu-end"
                  aria-labelledby="navbarDropdown"
                >
                  <a class="dropdown-item" href="#!">Action</a>
                  <a class="dropdown-item" href="#!">Another action</a>
                  <div class="dropdown-divider"></div>
                  <a class="dropdown-item" href="#!">Something else here</a>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </nav>
      <!-- Page content-->
      <div class="container-fluid">
        <RouterView />
      </div>
    </div>
  </div>
</template>
