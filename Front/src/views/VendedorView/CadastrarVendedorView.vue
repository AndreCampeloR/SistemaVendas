<template>
    <div class="main-container">
      <FormCadastro/>
    </div>
  </template>
  
  <script>
  import FormCadastro from '@/components/FormCadastro.vue';

  export default {
    name: 'CadastrarVendedorView',
    components: {
      FormCadastro
    }
  }
  </script>