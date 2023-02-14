<template>
    <div class="main-container">
      <FormCadastroVendedor/>
    </div>
  </template>
  
  <script>
  import FormCadastroVendedor from '@/components/Vendedor/FormCadastroVendedor.vue';

  export default {
    name: 'CadastrarVendedorView',
    components: {
      FormCadastroVendedor
    }
  }
  </script>