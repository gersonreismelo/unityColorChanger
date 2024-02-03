'use strict';

const { sanitizeEntity } = require('strapi-utils');

module.exports = {
  /**
   * Retrieve records.
   *
   * @return {Array}
   */
  async find(ctx) {
    const entities = await strapi.services.cor.find();

    const randomIndex = Math.floor(Math.random() * entities.length);
    const randomColor = entities[randomIndex];

    return sanitizeEntity(randomColor, { model: strapi.models.cor });
  },
};
