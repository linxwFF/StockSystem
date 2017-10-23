/*
Navicat MySQL Data Transfer

Source Server         : 127.0.0.1
Source Server Version : 50711
Source Host           : 127.0.0.1:3306
Source Database       : db_stocksys

Target Server Type    : MYSQL
Target Server Version : 50711
File Encoding         : 65001

Date: 2017-10-23 19:55:04
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_day_of_stock_info
-- ----------------------------
DROP TABLE IF EXISTS `t_day_of_stock_info`;
CREATE TABLE `t_day_of_stock_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code_name` varchar(255) DEFAULT NULL,
  `today_begin_price` decimal(10,2) DEFAULT NULL,
  `yesterday_end_price` decimal(10,2) DEFAULT NULL,
  `current_price` decimal(10,2) DEFAULT NULL,
  `day_height_price` decimal(10,2) DEFAULT NULL,
  `day_low_price` decimal(10,2) DEFAULT NULL,
  `buy_price` decimal(10,2) DEFAULT NULL,
  `sell_price` decimal(10,2) DEFAULT NULL,
  `number_of_traded_stock` int(11) DEFAULT NULL,
  `deal_price` decimal(10,2) DEFAULT NULL,
  `buy_1` int(11) DEFAULT NULL,
  `buy_1_price` decimal(10,2) DEFAULT NULL,
  `buy_2` int(11) DEFAULT NULL,
  `buy_2_price` decimal(10,2) DEFAULT NULL,
  `buy_3` int(11) DEFAULT NULL,
  `buy_3_price` decimal(10,2) DEFAULT NULL,
  `buy_4` int(11) DEFAULT NULL,
  `buy_4_price` decimal(10,2) DEFAULT NULL,
  `buy_5` int(11) DEFAULT NULL,
  `buy_5_price` decimal(10,2) DEFAULT NULL,
  `sell_1` int(11) DEFAULT NULL,
  `sell_1_price` decimal(10,2) DEFAULT NULL,
  `sell_2` int(11) DEFAULT NULL,
  `sell_2_price` decimal(10,2) DEFAULT NULL,
  `sell_3` int(11) DEFAULT NULL,
  `sell_3_price` decimal(10,2) DEFAULT NULL,
  `sell_4` int(11) DEFAULT NULL,
  `sell_4_price` decimal(10,2) DEFAULT NULL,
  `sell_5` int(11) DEFAULT NULL,
  `sell_5_price` decimal(10,2) DEFAULT NULL,
  `date` varchar(255) DEFAULT NULL,
  `time` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_day_of_stock_info
-- ----------------------------

-- ----------------------------
-- Table structure for t_hold_stock_info
-- ----------------------------
DROP TABLE IF EXISTS `t_hold_stock_info`;
CREATE TABLE `t_hold_stock_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `stock_holder_id` int(11) DEFAULT NULL,
  `stock_name` varchar(10) DEFAULT NULL,
  `stock_code` varchar(11) DEFAULT NULL,
  `amount_useable` int(11) DEFAULT NULL,
  `hold_quantity` int(11) DEFAULT NULL,
  `market_price` double DEFAULT NULL,
  `profit_loss` double DEFAULT NULL,
  `profit_loss_per` double DEFAULT NULL,
  `current_price` double DEFAULT NULL,
  `cost_price` double DEFAULT NULL,
  `commission_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_hold_stock_info
-- ----------------------------
INSERT INTO `t_hold_stock_info` VALUES ('1', '1', '东方材料', 'sh603110', '100', '100', '3328', '1128', '33.89', '33.28', '2200', '1');
INSERT INTO `t_hold_stock_info` VALUES ('2', '1', '国芳集团', 'sh601086', '100', '100', '1301', '301', '23.14', '13.01', '1000', '1');
INSERT INTO `t_hold_stock_info` VALUES ('3', '1', '四川长虹', 'sh600839', '100', '100', '388', '-12', '-3.09', '3.88', '400', '1');

-- ----------------------------
-- Table structure for t_personal_stock_account
-- ----------------------------
DROP TABLE IF EXISTS `t_personal_stock_account`;
CREATE TABLE `t_personal_stock_account` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bankroll` double DEFAULT NULL,
  `bankroll_useable` double DEFAULT NULL,
  `bankroll_freezed` double DEFAULT NULL,
  `bankroll_in_cash` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `total_stock` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_personal_stock_account
-- ----------------------------
INSERT INTO `t_personal_stock_account` VALUES ('2', '123123.22', '131231.221', '1212312.22', '1241.555', '13.554464', '13.5843');
INSERT INTO `t_personal_stock_account` VALUES ('1', '888.88', '8888888.88', '888888.88', '1241.555', '13.554464', '13.5843');

-- ----------------------------
-- Table structure for t_stock_holder
-- ----------------------------
DROP TABLE IF EXISTS `t_stock_holder`;
CREATE TABLE `t_stock_holder` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bankroll_id` int(11) DEFAULT NULL,
  `name` varchar(30) DEFAULT NULL,
  `personalID` varchar(50) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1223 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_stock_holder
-- ----------------------------
INSERT INTO `t_stock_holder` VALUES ('1', '1', '王耐金', '35033319912312312312', '13774545206', 'admin', 'admin');
INSERT INTO `t_stock_holder` VALUES ('2', '2', '王大锤', '1231231231231352352', '32432423423', 'guest', 'guest');

-- ----------------------------
-- Table structure for t_tactics
-- ----------------------------
DROP TABLE IF EXISTS `t_tactics`;
CREATE TABLE `t_tactics` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hold_stock_info_id` int(11) DEFAULT NULL,
  `loss_per` double DEFAULT NULL,
  `loss_quantity` int(11) DEFAULT NULL,
  `loss_tactics` int(11) DEFAULT NULL,
  `profit_per` double DEFAULT NULL,
  `profit_quantity` int(11) DEFAULT NULL,
  `profit_tactics` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_tactics
-- ----------------------------
INSERT INTO `t_tactics` VALUES ('1', '1', '0.2', '100', '1', '0.2', '100', '1');
