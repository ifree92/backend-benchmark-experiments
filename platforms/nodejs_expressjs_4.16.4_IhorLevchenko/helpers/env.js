function isDev() {
  return process.argv.indexOf('--dev') >= 0;
}

module.exports = {
  isDev,
};
