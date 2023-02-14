<template>
  <div class="main-container">
    <FormCadastroItem/>
  </div>
</template>

<script>
import FormCadastroItem from '@/components/itemPedido/FormCadastrarItem.vue';

export default {
  name: 'CadastrarItemView',
  components: {
    FormCadastroItem
  }
}
</script>