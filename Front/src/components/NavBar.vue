<template>
    <div>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
          <router-link class="navbar-brand"  to="/">Home</router-link>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav mr-auto">
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown"
                  aria-haspopup="true" aria-expanded="false">
                  Vendedor
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <router-link class="dropdown-item" to="/vendedor/listar">Listar </router-link>
                  <router-link class="dropdown-item" to="/vendedor/cadastrar">Cadastrar </router-link>
                </div>
              </li>
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown"
                  aria-haspopup="true" aria-expanded="false">
                  Cliente
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <router-link class="dropdown-item" to="/cliente/listar">Listar</router-link>
                  <router-link class="dropdown-item" to="/cliente/cadastrar">Cadastrar </router-link>
                </div>
              </li>
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown"
                  aria-haspopup="true" aria-expanded="false">
                  Serviços
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <router-link class="dropdown-item" to="/servico/listar">Listar </router-link>
                  <router-link class="dropdown-item" to="/servico/cadastrar">Cadastrar </router-link>
                </div>
              </li>
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown"
                  aria-haspopup="true" aria-expanded="false">
                  Pedidos
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                  <router-link class="dropdown-item" to="/pedido/listar">Listar </router-link>
                  <router-link class="dropdown-item" to="/pedido/cadastrar">Cadastrar</router-link>
                </div>
              </li>
        
            </ul>
          </div>
        </nav>
        <router-view />
    </div>
  </template>
  
  <script>
    
    export default {
      name: 'NavBar',
      components: {
          
    }
    }
    
  </script>
  
  <style scoped>
  
  </style>