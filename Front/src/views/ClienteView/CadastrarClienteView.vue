<template>
  <div class="main-container">
    <FormCadastroCliente/>
  </div>
</template>

<script>
import FormCadastroCliente from '@/components/Cliente/FormCadastroCliente.vue';

export default {
  name: 'CadastrarClienteView',
  components: {
    FormCadastroCliente
  }
}
</script>